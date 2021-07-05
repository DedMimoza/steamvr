using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFlying : MonoBehaviour
{
    private Rigidbody rig; //Объявляем переменную rig типа rigitbody
    private void Start()
    {
        Rigidbody rig = this.gameObject.GetComponent<Rigidbody>(); // Присваеваем в переменную rig компонент rigitbody из объекта 
        rig.AddForce(transform.forward*5f,ForceMode.Impulse); //Единожды даем объекту начальную скорость в направлении вперед 
    }
    
}
