using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerachangeLabirint : MonoBehaviour {

    public CameraFollow cam;
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.RightArrow)&&cam.Offset.x<10)
        {
            cam.Offset+=new Vector3(5, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && cam.Offset.x >-10)
        {
            cam.Offset += new Vector3(-5, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) )
        {
            cam.Offset = new Vector3(0, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            cam.Offset = new Vector3(0, 0, -1);
        }

    }
}
