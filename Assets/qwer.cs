using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

namespace Valve.VR.InteractionSystem
{

    public class qwer : MonoBehaviour
    {
        public SteamVR_Action_Boolean men = SteamVR_Input.GetBooleanAction("instobj"); //Обращаемся к используемому методу

        public GameObject shar;  //Объект, который будет появляться при нажатии
        public GameObject orig;       //Физика шара
        
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            bool cool = men.GetStateDown(SteamVR_Input_Sources.Any);///проверка на нажатие кнопки на контроллере 
            if (cool)
            {
                GameObject.Instantiate(shar, orig.transform.position, Quaternion.identity); //Создание шара в определённой позиции
            }
        }
    }
}