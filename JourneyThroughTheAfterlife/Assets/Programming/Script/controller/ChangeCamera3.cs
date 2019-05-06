using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera3 : MonoBehaviour {
    public CameraFollow changeoffset;
	public bool changenumb=false;


    void OnTriggerEnter(Collider other)
    {
		if (other.tag == "Player"&&changenumb==false)
        {
            changeoffset.Offset = new Vector3(0,2,10);

        }
		if (other.tag == "Player"&&changenumb==true)
		{
			changeoffset.Offset = new Vector3(-10,2,0);

		}

    }
}
