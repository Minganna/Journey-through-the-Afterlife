using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cerberus : MonoBehaviour {

    public Animator ani;
    public bool nextlevel = false;
    public GameObject DoorLight;

    void OnTriggerStay( Collider other)
	{
			if (other.tag == "Pickable" ) {

            ani.SetBool("Food", true);
            DoorLight.SetActive(true);
            nextlevel = true;


}
		}
}
