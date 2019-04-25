using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daniil_TestTrigger : MonoBehaviour {

	private Animator _animator;

	// Use this for initialization
	void Start () {
		_animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			_animator.SetBool ("open", true);
		}
	}
	void OnTriggerExit(Collider other)
	{
		_animator.SetBool ("open", false);
	}
}
