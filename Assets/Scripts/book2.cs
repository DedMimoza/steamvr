using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book2 : MonoBehaviour
{
    public Transform target;

    private float smoothTimes = 0.1f;

    private float distance = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.parent.name == "RightHand" || this.gameObject.transform.parent.name == "LeftHand")
        {
            transform.position = Vector3.Lerp(transform.position, target.position + target.forward * distance, smoothTimes);
            transform.LookAt(target);
        }
    }
}
