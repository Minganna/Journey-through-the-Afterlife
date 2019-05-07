using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastCamerachange : MonoBehaviour {

    public CameraFollow cam;
    public int numb = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && numb == 0)
        {
            cam.Offset = new Vector3(-10, 2, 0);
        }
        if (other.tag == "Player" && numb == 1)
        {
            cam.Offset = new Vector3(20, 2, 0);
        }
    }
}
