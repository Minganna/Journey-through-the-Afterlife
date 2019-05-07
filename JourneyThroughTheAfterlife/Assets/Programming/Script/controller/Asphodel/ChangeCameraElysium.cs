using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraElysium : MonoBehaviour {

    public CameraFollow cam;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cam.Offset = new Vector3(0, 2, 20);
        }
    }
}
