﻿using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


namespace mainpart
{
    internal class color : MonoBehaviour
    {
        public Material newmat1;
        public GameObject gorilla;

        public void Start()
        {
            //Find the Standard Shader
            newmat1 = new Material(Shader.Find("Standard"));



            gorilla = GameObject.Find("Global/Local VRRig/Local Gorilla Player/gorilla");
            this.gameObject.GetComponent<MeshRenderer>().material = newmat1;


            Update();
        }

        public void Update()
        {
            
            this.gameObject.GetComponent<MeshRenderer>().material.color = gorilla.GetComponent<SkinnedMeshRenderer>().material.color; 



        }
    }
}