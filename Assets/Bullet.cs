using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

namespace Valve.VR.InteractionSystem
{


    public class Bullet : MonoBehaviour
    {
        public GameObject bullet;
        public GameObject dulo;
        private bool isshot=true;

        public SteamVR_Action_Boolean men = SteamVR_Input.GetBooleanAction("Shooting");
        
        void Start()
        {

        }

        private void Update()
        {    
            
            
            bool cool = men.GetState(SteamVR_Input_Sources.Any);
            if ((this.gameObject.transform.parent.name == "LeftHand" || this.gameObject.transform.parent.name == "RightHand")&& cool && isshot)
            {
                GameObject.Instantiate(bullet, dulo.transform.position, Quaternion.Euler(dulo.transform.eulerAngles));
                isshot = false;
                StartCoroutine(shootdelay());
            }
        }

        IEnumerator shootdelay()
        {
            yield return new WaitForSeconds(0.5f);
            isshot = true;
        }

    }
}

