using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

namespace Valve.VR.InteractionSystem
{


    public class Bullet : MonoBehaviour
    {
        public GameObject bullet; //Пуля    
        public GameObject dulo; //Место, в котором создается пуля
        private bool isshot=true; //Возможность стрелять
        private Animator anim; //Анимация
        public SteamVR_Action_Boolean men = SteamVR_Input.GetBooleanAction("Shooting"); //Объявляем используемый метод
        
        void Start()
        {
            anim = gameObject.GetComponent<Animator>(); //Берем компонент аниматора у объекта, к которому привязан скрипт
        }

        private void Update()
        {    
            
            
            bool cool = men.GetState(SteamVR_Input_Sources.Any); //Нажатие кнопки контроллерак 
            if ((this.gameObject.transform.parent.name == "LeftHand" || this.gameObject.transform.parent.name == "RightHand")&& cool && isshot) //Проверяем наличие пистолета в одной из рук пистолета, нажатие кнопки контроллера и возможности стрелять
            {
                GameObject.Instantiate(bullet, dulo.transform.position, Quaternion.Euler(dulo.transform.eulerAngles)); //Создаем пулю в пистолете
                isshot = false;        //Ограничиваем возможность стрелять до следующего возврата coroutine
                anim.Play("New Animation"); //Проигрываем анимацию выстрела
                StartCoroutine(shootdelay()); 
                
            }
        }

        IEnumerator shootdelay()
        {
            yield return new WaitForSeconds(0.5f);         //Возвращает время последнего нажатия
            isshot = true; //Возвращаем возможность стрелять 
        }

    }
}

