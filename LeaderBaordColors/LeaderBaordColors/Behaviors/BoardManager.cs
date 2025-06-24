using System.Collections.Generic;
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
            Vector3 pos, rot, scale;
            string path;
            bool modify;

            switch (scene.name)
            {
                case "Canyon2":
                    path = "Canyon/CanyonScoreboardAnchor/GorillaScoreBoard";
                    pos = new Vector3(-24.5019f, -28.7746f, 0.1f);
                    rot = new Vector3(270f, 0f, 0f);
                    scale = new Vector3(21.5946f, 1f, 22.1782f);
                    modify = true;
                    break;

                case "Skyjungle":
                    path = "skyjungle/UI/Scoreboard/GorillaScoreBoard";
                    pos = new Vector3(-21.2764f, -32.1928f, 0f);
                    rot = new Vector3(270.2987f, 0.2f, 359.9f);
                    scale = new Vector3(21.6f, 0.1f, 20.4909f);
                    modify = true;
                    break;

                case "Mountain":
                    path = "Mountain/MountainScoreboardAnchor/GorillaScoreBoard";
                    pos = Vector3.zero;
                    rot = Vector3.zero;
                    scale = Vector3.one;
                    modify = false;
                    break;

                case "Metropolis":
                    path = "MetroMain/ComputerArea/Scoreboard/GorillaScoreBoard";
                    pos = new Vector3(-25.1f, -31f, 0.1502f);
                    rot = new Vector3(270.1958f, 0.2086f, 0f);
                    scale = new Vector3(21f, 102.9727f, 21.4f);
                    modify = true;
                    break;

                case "Bayou":
                    path = "BayouMain/ComputerArea/GorillaScoreBoardPhysical";
                    pos = new Vector3(-28.3419f, -26.851f, 0.3f);
                    rot = new Vector3(270f, 0f, 0f);
                    scale = new Vector3(21.3636f, 38f, 21f);
                    modify = true;
                    break;

                case "Beach":
                    path = "BeachScoreboardAnchor/GorillaScoreBoard";
                    pos = new Vector3(-22.1964f, -33.7126f, 0.1f);
                    rot = new Vector3(270.056f, 0f, 0f);
                    scale = new Vector3(21.2f, 2f, 21.6f);
                    modify = true;
                    break;

                case "Cave":
                    path = "Cave_Main_Prefab/CrystalCaveScoreboardAnchor/GorillaScoreBoard";
                    pos = new Vector3(-22.1964f, -33.7126f, 0.1f);
                    rot = new Vector3(270.056f, 0f, 0f);
                    scale = new Vector3(21.2f, 2f, 21.6f);
                    modify = true;
                    break;

                case "Rotating":
                    path = "RotatingPermanentEntrance/UI (1)/RotatingScoreboard/RotatingScoreboardAnchor/GorillaScoreBoard";
                    pos = new Vector3(-22.1964f, -33.7126f, 0.1f);
                    rot = new Vector3(270.056f, 0f, 0f);
                    scale = new Vector3(21.2f, 2f, 21.6f);
                    modify = true;
                    break;

                case "MonkeBlocks":
                    path = "Environment Objects/MonkeBlocksRoomPersistent/AtticScoreBoard/AtticScoreboardAnchor/GorillaScoreBoard";
                    pos = new Vector3(-22.1964f, -24.5091f, 0.57f);
                    rot = new Vector3(270.1856f, 0.1f, 0f);
                    scale = new Vector3(21.6f, 1.2f, 20.8f);
                    modify = true;
                    break;

                case "Basement":
                    path = "Basement/BasementScoreboardAnchor/GorillaScoreBoard/";
                    pos = new Vector3(-22.1964f, -24.5091f, 0.57f);
                    rot = new Vector3(270.1856f, 0.1f, 0f);
                    scale = new Vector3(21.6f, 1.2f, 20.8f);
                    modify = true;
                    break;

                default:
                    return;
            }

            LoadBoard(path, modify, pos, rot, scale);
        }
    }
}
