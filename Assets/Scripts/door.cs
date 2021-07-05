using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class door : MonoBehaviour
{
    public GameObject ruchka;
    private CircularDrive circularDrive;

    void Start()
    {
        circularDrive = gameObject.GetComponent<CircularDrive>();
        circularDrive.minAngle = 0;
        circularDrive.maxAngle = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.transform.eulerAngles.y);
        if (ruchka.transform.localEulerAngles.x>330)
        {
            circularDrive.minAngle = -90;
            circularDrive.maxAngle = 90;
        }
        else if (gameObject.transform.eulerAngles.y<1)
        {
            circularDrive.minAngle = 0;
            circularDrive.maxAngle = 0;
        }
        else
        {
            circularDrive.minAngle = -90;
            circularDrive.maxAngle = 90;
        }
    }
}