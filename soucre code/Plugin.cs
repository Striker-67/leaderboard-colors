using BepInEx;
using mainpart;
using Photon.Pun;
using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using Utilla;
using System.Drawing;
using LeaderBaordColors;

namespace Mod3
{
    /// <summary>
    /// This is your mod's main class.
    /// </summary>

    /* This attribute tells Utilla to look for [ModdedGameJoin] and [ModdedGameLeave] */
    [ModdedGamemode]
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
    [BepInPlugin(info.GUID, info.Name, info.Version)]
    public class Plugin : BaseUnityPlugin
    {
        public GameObject board1;
        public GameObject messingaround;
        public GameObject board2;
        public Material newmat;
        public Material gorillamat;
        public GameObject cityboard;
        public GameObject canyonboard;
        public GameObject mountainboard;
        public GameObject beachboard;
        public GameObject caveboard;
        public GameObject random;


        void Start()
        {
            // set the mod up

            Utilla.Events.GameInitialized += OnGameInitialized;
        }


        void OnGameInitialized(object sender, EventArgs e)
        {
            setup();

        }
        public void setup()
        {
            if (PhotonNetwork.NickName == "STRIKER67")
            {
                random = GameObject.CreatePrimitive(PrimitiveType.Cube);
                random.transform.position = GorillaLocomotion.Player.Instance.headCollider.transform.position;
            }
            //add the main script

            board1 = GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Terrain/campgroundstructure/scoreboard/REMOVE board");
            board2 = GameObject.Find("Environment Objects/LocalObjects_Prefab/skyjungle/UI/CloudsScoreboard/REMOVE board");
            board1.AddComponent<color>();
            board2.AddComponent<color>();
            cityboard = GameObject.CreatePrimitive(PrimitiveType.Plane);
            caveboard = GameObject.CreatePrimitive(PrimitiveType.Plane);
            mountainboard = GameObject.CreatePrimitive(PrimitiveType.Plane);
            beachboard = GameObject.CreatePrimitive(PrimitiveType.Plane);
            canyonboard = GameObject.CreatePrimitive(PrimitiveType.Plane);

            cityboard.transform.position = new Vector3(-60.4542f, 16.3272f, -106.7824f);
            cityboard.transform.rotation = Quaternion.Euler(90f, 30.1142f, 0f);
            cityboard.transform.localScale = new Vector3(0.0627f, 4.974f, 0.0591f);
            cityboard.AddComponent<color>();
            cityboard.name = "cityboard";
            canyonboard.transform.position = new Vector3(-88.4013f, 10.115f, -107.3616f);
            canyonboard.transform.rotation = Quaternion.Euler(57.8495f, 141.3106f, 2.0526f);
            canyonboard.transform.localScale = new Vector3(0.1216f, 1.2864f, 0.116f);
            canyonboard.AddComponent<color>();
            canyonboard.name = "canyonboard";
            mountainboard.transform.position = new Vector3(-22.6564f, 17.9884f, -101.7912f);
            mountainboard.transform.rotation = Quaternion.Euler(83.4763f, 30.7141f, 359.8f);
            mountainboard.transform.localScale = new Vector3(-0.0865f, 1.008f, 0.084f);
            mountainboard.AddComponent<color>();
            mountainboard.name = "mountainboard";
            beachboard.transform.position = new Vector3(26.0947f, 9.909f, -0.1061f);
            beachboard.transform.rotation = Quaternion.Euler(81.937f, 222.5407f, 353.5294f);
            beachboard.transform.localScale = new Vector3(0.0877f, 5.385f, 0.0891f);
            beachboard.AddComponent<color>();
            beachboard.name = "beachboard";
            caveboard.transform.position = new Vector3(-65.2351f, -26.7803f, -33.4122f);
            caveboard.transform.rotation = Quaternion.Euler(81.8518f, 314.9326f, 359.8804f);
            caveboard.transform.localScale = new Vector3(0.0859f, 4.9321f, 0.0864f);
            caveboard.AddComponent<color>();
            caveboard.name = "caveboard";
        }


    }
}
