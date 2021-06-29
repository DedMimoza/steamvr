using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFlying : MonoBehaviour
{
    private Rigidbody rig;
    private void Start()
    {
        Rigidbody rig = this.gameObject.GetComponent<Rigidbody>();
        rig.AddForce(transform.forward*5f,ForceMode.Impulse);
    }

    void Update()
    {
        
    }
}
