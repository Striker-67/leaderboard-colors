using BepInEx;
using mainpart;
using System;
using UnityEngine;
using Utilla;

namespace Mod3
{
    /// <summary>
    /// This is your mod's main class.
    /// </summary>

    /* This attribute tells Utilla to look for [ModdedGameJoin] and [ModdedGameLeave] */
    [ModdedGamemode]
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        public GameObject board1;
        public GameObject board2;
        public Material newmat;
        public Material gorillamat;
 

        void Start()
        {
         // set the mod up

            Utilla.Events.GameInitialized += OnGameInitialized;
        }


        void OnGameInitialized(object sender, EventArgs e)
        {
            //calls for setup
            setup();
        }
        public void setup()
        {
            //add the main script
            board1 = GameObject.Find("Level/forest/ForestObjects/campgroundstructure/scoreboard/REMOVE board");
            board2 = GameObject.Find("Level/skyjungle/UI/CloudsScoreboard/REMOVE board");
            board1.AddComponent<color>();
            board2.AddComponent<color>();

        }


    }
}
