using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daniil_TestTrigger : MonoBehaviour {

	private Animator _animator;
	[SerializeField] bool Interact = false;

	// Use this for initialization
	void Start () {
		_animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("e"))
		{
				_animator.SetBool ("open", true);	
		}
    }
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			Interact = true;
		}
	}

	void OnTriggerExit(Collider other)
	{
		Interact = false;
	}
}
