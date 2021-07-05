using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text_orent : MonoBehaviour
{
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - Camera.main.transform.position, Vector3.up);
    }
}
