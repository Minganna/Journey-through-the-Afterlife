using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera3 : MonoBehaviour {
    public CameraFollow changeoffset;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            changeoffset.Offset = new Vector3(0,2,10);

        }
    }
}
