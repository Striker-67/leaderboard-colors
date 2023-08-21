using BepInEx;
using System;
using UnityEngine;
using Utilla;

namespace Mod3
{
    [ModdedGamemode]
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        public GameObject board1;
        public GameObject board2;
        public Material newmat;
        public Material gorillamat;

        private struct BoardInfo
        {
            public string Name;
            public Vector3 Position;
            public Quaternion Rotation;
            public Vector3 Scale;

            public BoardInfo(string name, Vector3 position, Quaternion rotation, Vector3 scale)
            {
                Name = name;
                Position = position;
                Rotation = rotation;
                Scale = scale;
            }
        }

        private BoardInfo[] boardConfigs = new BoardInfo[]
        {
            new BoardInfo("cityboard", new Vector3(-60.4542f, 16.3272f, -106.7824f), Quaternion.Euler(90f, 30.1142f, 0f), new Vector3(0.0627f, 4.974f, 0.0591f)),
            new BoardInfo("canyonboard", new Vector3(-88.4013f, 10.115f, -107.3616f), Quaternion.Euler(57.8495f, 141.3106f, 2.0526f), new Vector3(0.1216f, 1.2864f, 0.116f)),
            new BoardInfo("mountainboard", new Vector3(-22.6564f, 17.9884f, -101.7912f), Quaternion.Euler(83.4763f, 30.7141f, 359.8f), new Vector3(-0.0865f, 1.008f, 0.084f)),
            new BoardInfo("beachboard", new Vector3(26.0947f, 9.909f, -0.1061f), Quaternion.Euler(81.937f, 222.5407f, 353.5294f), new Vector3(0.0877f, 5.385f, 0.0891f)),
            new BoardInfo("caveboard", new Vector3(-65.2351f, -26.7803f, -33.4122f), Quaternion.Euler(81.8518f, 314.9326f, 359.8804f), new Vector3(0.0859f, 4.9321f, 0.0864f))
        };

        void Start()
        {
            Utilla.Events.GameInitialized += OnGameInitialized;
        }

        void OnGameInitialized(object sender, EventArgs e)
        {
            Setup();
        }

        public void Setup()
        {
            board1 = GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Terrain/campgroundstructure/scoreboard/REMOVE board");
            board2 = GameObject.Find("Environment Objects/LocalObjects_Prefab/skyjungle/UI/CloudsScoreboard/REMOVE board");
            board1.AddComponent<color>();
            board2.AddComponent<color>();

            foreach (var config in boardConfigs)
            {
                var board = GameObject.CreatePrimitive(PrimitiveType.Plane);
                board.transform.position = config.Position;
                board.transform.rotation = config.Rotation;
                board.transform.localScale = config.Scale;
                board.AddComponent<color>();
                board.name = config.Name;
            }
        }
    }
}
