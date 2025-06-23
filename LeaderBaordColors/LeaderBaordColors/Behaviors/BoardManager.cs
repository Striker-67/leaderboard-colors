﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LeaderBaordColors.Behaviors
{
    public class BoardManager : MonoBehaviour
    {
        public List<GameObject> boards = new List<GameObject>();
        public List<string> boardPaths = new List<string>();

        private void Start()
        {
            GorillaTagger.OnPlayerSpawned(Setup);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        public void Setup()
        {
            boardPaths.Add("Environment Objects/LocalObjects_Prefab/Forest/ForestScoreboardAnchor/GorillaScoreBoard");
            boardPaths.Add("Environment Objects/LocalObjects_Prefab/City_WorkingPrefab/CosmeticsScoreboardAnchor/GorillaScoreBoard");
            LoadBoard("Environment Objects/LocalObjects_Prefab/City_WorkingPrefab/Arcade_prefab/Arcade_Room/CosmeticsScoreboardAnchor/GorillaScoreBoard", true, new Vector3(-22.1964f, -21.4581f, 1.4f), new Vector3(270.0593f, 0f, 0f), new Vector3(23f, 2.1f, 21.6f));
            for (int i = 0; i < 2; i++)
            {
                var board = GameObject.CreatePrimitive(PrimitiveType.Plane);
                board.transform.parent = GameObject.Find(boardPaths[i]).transform;
                board.AddComponent<ColorManager>();
                board.transform.localPosition = new Vector3(-22.1964f, -34.9f, 0.57f);
                board.transform.localRotation = Quaternion.Euler(270f, 0f, 0f);
                board.transform.localScale = new Vector3(21.2f, 2f, 21.6f);
                boards.Add(board);
            }
        }

        public void LoadBoard(string id, bool overridePos, Vector3 pos, Vector3 rot, Vector3 scale)
        {
            var board = GameObject.CreatePrimitive(PrimitiveType.Plane);
            board.transform.parent = GameObject.Find(id).transform;
            board.AddComponent<ColorManager>();
            board.transform.localPosition = overridePos ? pos : new Vector3(-22.1964f, -34.9f, 0.57f);
            board.transform.localRotation = Quaternion.Euler(overridePos ? rot : new Vector3(270f, 0f, 0f));
            board.transform.localScale = overridePos ? scale : new Vector3(21.2f, 2f, 21.6f);
            boards.Add(board);
        }

        public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            if (scene.name == "Canyon2")
                LoadBoard("Canyon/CanyonScoreboardAnchor/GorillaScoreBoard", true, new Vector3(-24.5019f, -28.7746f, 0.1f), new Vector3(270f, 0f, 0f), new Vector3(21.5946f, 1f, 22.1782f));
            if (scene.name == "Skyjungle")
                LoadBoard("skyjungle/UI/Scoreboard/GorillaScoreBoard", true, new Vector3(-21.2764f, -32.1928f, 0f), new Vector3(270.2987f, 0.2f, 359.9f), new Vector3(21.6f, 0.1f, 20.4909f));
            if (scene.name == "Mountain")
                LoadBoard("Mountain/MountainScoreboardAnchor/GorillaScoreBoard", false, Vector3.zero, Vector3.zero, Vector3.one);
            if (scene.name == "Metropolis")
                LoadBoard("MetroMain/ComputerArea/Scoreboard/GorillaScoreBoard", true, new Vector3(-25.1f, -31f, 0.1502f), new Vector3(270.1958f, 0.2086f, 0f), new Vector3(21f, 102.9727f, 21.4f));
            if (scene.name == "Bayou")
                LoadBoard("BayouMain/ComputerArea/GorillaScoreBoardPhysical", true, new Vector3(-28.3419f, -26.851f, 0.3f), new Vector3(270f, 0f, 0f), new Vector3(21.3636f, 38f, 21f));
            if (scene.name == "Beach")
                LoadBoard("BeachScoreboardAnchor/GorillaScoreBoard", true, new Vector3(-22.1964f, -33.7126f, 0.1f), new Vector3(270.056f, 0f, 0f), new Vector3(21.2f, 2f, 21.6f));
            if (scene.name == "Cave")
                LoadBoard("Cave_Main_Prefab/CrystalCaveScoreboardAnchor/GorillaScoreBoard", true, new Vector3(-22.1964f, -33.7126f, 0.1f), new Vector3(270.056f, 0f, 0f), new Vector3(21.2f, 2f, 21.6f));
            if (scene.name == "Rotating")
                LoadBoard("RotatingPermanentEntrance/UI (1)/RotatingScoreboard/RotatingScoreboardAnchor/GorillaScoreBoard", true, new Vector3(-22.1964f, -33.7126f, 0.1f), new Vector3(270.056f, 0f, 0f), new Vector3(21.2f, 2f, 21.6f));
            if (scene.name == "MonkeBlocks")
                LoadBoard("Environment Objects/MonkeBlocksRoomPersistent/AtticScoreBoard/AtticScoreboardAnchor/GorillaScoreBoard", true, new Vector3(-22.1964f, -24.5091f, 0.57f), new Vector3(270.1856f, 0.1f, 0f), new Vector3(21.6f, 1.2f, 20.8f));
            if (scene.name == "Basement")
                LoadBoard("Basement/BasementScoreboardAnchor/GorillaScoreBoard/", true, new Vector3(-22.1964f, -24.5091f, 0.57f), new Vector3(270.1856f, 0.1f, 0f), new Vector3(21.6f, 1.2f, 20.8f));
        }
    }
}