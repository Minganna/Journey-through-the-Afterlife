using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

	private float speedcharacter;
	public Animator Animation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Animation.SetFloat ("Speed", speedcharacter);

		if (Input.GetKeyDown(KeyCode.UpArrow)||Input.GetKeyDown(KeyCode.RightArrow)||Input.GetKeyDown(KeyCode.DownArrow)||Input.GetKeyDown(KeyCode.LeftArrow)) {
			speedcharacter = 1.0f;
		}
		if (Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.D)||Input.GetKeyDown(KeyCode.S)||Input.GetKeyDown(KeyCode.A)) {
			speedcharacter = 1.0f;
		}

		if (Input.GetKeyUp(KeyCode.UpArrow)||Input.GetKeyUp(KeyCode.RightArrow)||Input.GetKeyUp(KeyCode.DownArrow)||Input.GetKeyUp(KeyCode.LeftArrow)) {
			if (Input.anyKey == false) {
				speedcharacter = 0.0f;
			}
		}
		if (Input.GetKeyUp(KeyCode.W)||Input.GetKeyUp(KeyCode.D)||Input.GetKeyUp(KeyCode.S)||Input.GetKeyUp(KeyCode.A)) {
			if (Input.anyKey == false) {
				speedcharacter = 0.0f;
			}
		}

	}
}
