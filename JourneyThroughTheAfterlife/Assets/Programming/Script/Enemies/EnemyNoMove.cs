using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNoMove : MonoBehaviour {
	public GameObject enemy;
	Animator anim;
	public Transform player;
	// Use this for initialization
	void Start () {
		anim = enemy.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(){
		transform.LookAt (player);
		enemy.GetComponent<Animator> ().SetBool ("Attack", true);
	}

	void OnTriggerExit(){
		enemy.GetComponent<Animator> ().SetBool ("Attack", false);
	}
}
