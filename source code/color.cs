﻿using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using GorillaNetworking;

namespace mainpart
{
    internal class color : MonoBehaviour
    {
        public Material newmat1;
        public GameObject gorilla;
        public GameObject computer;

        public void Start()
        {
            //Find the Standard Shader
            newmat1 = new Material(Shader.Find("Standard"));
            computer = GameObject.Find("Global/Photon Manager/GorillaComputer");
            
            gorilla = GameObject.Find("Global/Local VRRig/Local Gorilla Player");

            this.gameObject.GetComponent<MeshRenderer>().material = newmat1;

            

        }

        public void Update()
        {

            this.gameObject.GetComponent<MeshRenderer>().material.color = gorilla.GetComponent<VRRig>().playerColor;



        }
    }
}
