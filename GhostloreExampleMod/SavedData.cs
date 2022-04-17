using System;
using ProtoBuf;

namespace GhostloreExampleMod {

    /// <summary>
    /// Example data structure to serialize.
    /// </summary>
    [ProtoContract(SkipConstructor = true)]
    public class SavedData
    {
        [ProtoMember(1)]
        public int SavedNumber;
        [ProtoMember(2)]
        public DateTime SavedDate;

    }
}