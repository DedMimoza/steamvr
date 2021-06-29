using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

namespace Valve.VR.InteractionSystem
{

    public class qwer : MonoBehaviour
    {
        public SteamVR_Action_Boolean men = SteamVR_Input.GetBooleanAction("instobj");

        public GameObject shar;
        public GameObject orig;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            bool cool = men.GetStateDown(SteamVR_Input_Sources.Any);
            if (cool)
            {
                if (!(orig is null)) GameObject.Instantiate(shar, orig.transform.position, Quaternion.identity);
            }
        }
    }
}