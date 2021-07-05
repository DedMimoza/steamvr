using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEngine;
using Valve.VR;

namespace Valve.VR.InteractionSystem
{
    public class newmoving : MonoBehaviour
    {
        public SteamVR_Action_Vector2 map = SteamVR_Input.GetVector2Action("moving123"); // Объявляем используемый метод
        public Transform cameraTransform; //Объявляем публичную переменную для камеры
        private CapsuleCollider capscol; //Объявляем переменную для коллайдера нашего тела в режиме VR
        void Start()
        {
            capscol = GetComponent<CapsuleCollider>(); //Помещаем в нашу переменную коллайдер из объекта
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            Vector3 vaaf = Player.instance.hmdTransform.TransformDirection(map.axis.x, 0, map.axis.y); //Создаем вектор, направленный в сторону наклона стика контроллера
            transform.position += Vector3.ProjectOnPlane(vaaf*Time.deltaTime*2.0f, Vector3.up); //Переносим нас на вектор расположенный на нормали параллельной плоскости

            float Dflor = Vector3.Dot(cameraTransform.localPosition, Vector3.up);//Расположение камеры(головы) относительно перепендикуляра, опущенного к полу
            capscol.height = Mathf.Max(capscol.radius, Dflor);//Изменяем размер коллайдера тело в зависимости от роста человека с шлемом
            capscol.center = cameraTransform.localPosition - 0.5f * Dflor * Vector3.up;//Изменяем центр коллайдера относительно камеры(головы)
        }
    }
}

