using System;
using UnityEngine;

namespace GhostloreExampleMod {
    /// <summary>
    /// Example class which just draws some text on the screen.
    /// </summary>
    public class ExampleNumberDrawer : MonoBehaviour
    {
        private SavedData data;

        public SavedData Data => data;

        public void Init()
        {
            if (ModDataSerializer.Data != null)
            {
                this.data = ModDataSerializer.Data;
            }
            else
            {
                this.data = new SavedData() { SavedDate = DateTime.Now, SavedNumber = UnityEngine.Random.Range(0, 42) };
            }
        }
        
        void OnGUI()
        {
            if (data == null)
            {
                return;
            }
            GUI.Label(new Rect(10, 10, 100, 20), "lucky number: " + data.SavedNumber.ToString());
            GUI.Label(new Rect(10, 25, 100, 20), "game created on: " + data.SavedDate.ToString());
        }

    }
}