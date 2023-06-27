using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace mainpart
{
    internal class color : MonoBehaviour
    {
        public Material newmat;
        public GameObject board;
        public void Start()
        {
            //Find the Standard Shader
            newmat = new Material(Shader.Find("Standard"));

            newmat.color = GameObject.Find("Global/Local VRRig/Local Gorilla Player/gorilla").GetComponent<SkinnedMeshRenderer>().material.color;

            board = GameObject.Find("Level/forest/ForestObjects/campgroundstructure/scoreboard/REMOVE board");
            board.GetComponent<Renderer>().material = newmat;
            Update();
        }
        public void Update()
        {
            newmat.color = GameObject.Find("Global/Local VRRig/Local Gorilla Player/gorilla").GetComponent<SkinnedMeshRenderer>().material.color;
        }
    }
}
