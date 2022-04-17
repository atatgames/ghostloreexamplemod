using System.IO;
using ProtoBuf.Meta;

namespace GhostloreExampleMod {
    /// <summary>
    /// Class to save persistant data.
    /// Do not inherit IModDataSerializer if your mod does not have persistant data you need to save.
    /// </summary>
    public class ModDataSerializer : IModDataSerializer
    {
        public static SavedData Data { get; set; }
        /// <summary>
        /// Called after save file is deserialized. The object returned is deserialized from additional save data unique to each mod and save game.
        /// SavedObject will be null if this additional save file is not found.
        /// In this example we use protobuf (https://github.com/protocolbuffers/protobuf/tree/master/csharp), which Ghostlore uses as well, but you may serialize and deserialize data however you like.
        /// Not that deserializing the save file occurs before the OnGameLoaded IModLoader callback is called.
        /// </summary>
        /// <param name="savedObject">Deserialized object, null if none found.</param>
        public void OnSaveDeserialized(object savedObject)
        {
            if (savedObject == null) //savedObject will be null if the user hasn't saved their game with the mod on before, so we need to do a null check.
            {
                return;
            }
            Data = (SavedData)savedObject;
        }

        /// <summary>
        /// Method to serialize your save data. We use protobuf to serialize our SavedData class
        /// </summary>
        /// <param name="saveFile">The file which Ghostlore makes for your mod</param>
        public void SerializeSave(Stream saveFile)
        {
            var model = TypeModel.Create();
            model.Serialize(saveFile, ModLoader.testNumber.Data);
        }

        /// <summary>
        /// Method to deserialize your save file. We use protobuf to deserialize the file into our SavedData class.
        /// </summary>
        /// <param name="saveFile">The file which Ghostlore makes for your mod, method will not be called if no file is found</param>
        /// <returns>The deserialized object</returns>
        public object DeserializeSave(Stream saveFile)
        {
            var model = TypeModel.Create();
            return model.Deserialize(saveFile, null, typeof(SavedData));
        }
    }
}