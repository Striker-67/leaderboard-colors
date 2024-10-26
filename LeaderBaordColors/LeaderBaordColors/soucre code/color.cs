using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using GorillaNetworking;
using LeaderBaordColors;

namespace mainpart
{
    public class color : MonoBehaviour
    {
        public Material newmat1;
        public GameObject gorilla;
        public GameObject computer;
        public float value;
       

        public void Start()
        {
            //Find the Standard Shader
            newmat1 = new Material(Shader.Find("GorillaTag/UberShader"));


           

            this.gameObject.GetComponent<MeshRenderer>().material = newmat1;

            

        }
        private void Update()
        {
            newmat1.color = GorillaTagger.Instance.offlineVRRig.playerColor;
        }


    }
}
