using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.isKinematic = (gameObject.transform.parent.name == "RightHand" ||
                          gameObject.transform.parent.name == "LeftHand");
        foreach (Transform child in transform)
        {
            child.GetComponent<Rigidbody>().isKinematic = (gameObject.transform.parent.name == "RightHand" ||
                                                           gameObject.transform.parent.name == "LeftHand");
        }
        
    }
}
