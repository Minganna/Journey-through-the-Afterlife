using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfLabyrint : MonoBehaviour {

    public CameraFollow cam;
    public GameObject camscript;
    public GameObject minimapManager;
    public GameObject PlayerLight;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            camscript.GetComponent<CamerachangeLabirint>().enabled = true;
            cam.Offset = new Vector3(0, 2, 1);
            minimapManager.SetActive(true);
        }

    }


    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            camscript.GetComponent<CamerachangeLabirint>().enabled = false;
            cam.Offset = new Vector3(-10, 2, 0);
            Destroy(minimapManager);
            Destroy(PlayerLight);
        }

    }
}
