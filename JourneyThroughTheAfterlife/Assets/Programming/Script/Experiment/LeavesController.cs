using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeavesController : MonoBehaviour {

    public int numbwall=0;
    public bool activate1;
    public bool activate2;
	

    private void OnTriggerEnter(Collider other)
    {
		if (other.tag == "Player") {
			if (numbwall == 0) {
				activate1 = true;
			}
			if (numbwall == 1) {
				activate2 = true;
			}
		}
    }

}
