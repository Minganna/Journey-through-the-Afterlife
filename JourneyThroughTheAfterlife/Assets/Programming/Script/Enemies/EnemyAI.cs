using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

	public GameObject enemy;
	Animator anim;
	public Transform player;
	public float moveSpeed = 4f;
	private float minDist = 1f;

	// Use this for initialization
	void Start () {
		anim = enemy.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (transform.position, player.position) >= minDist) {
			transform.LookAt (player);
			transform.position += transform.forward * moveSpeed * Time.deltaTime;
			enemy.GetComponent<Animator> ().SetBool ("Aggro", true);
		} else {
			enemy.GetComponent<Animator> ().SetBool ("Aggro", false);
		}
	}

	void OnTriggerEnter(){
		enemy.GetComponent<Animator> ().SetBool ("Attack", true);
	}

	void OnTriggerExit(){
		enemy.GetComponent<Animator> ().SetBool ("Attack", false);
	}
}
