using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryItemCollision : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col)
	{
		//Check collision name
		Debug.Log("collision name = " + col.gameObject.name);
		if(col.gameObject.name == "InteractTrigger")
		{
			Destroy(gameObject);
		}
	}
}
