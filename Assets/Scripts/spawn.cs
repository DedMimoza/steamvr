using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject predmet;

    // Update is called once per frame
    public void desp()
    {
        Instantiate(predmet, transform.position, Quaternion.identity);
    }
}
