using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameScene1 : MonoBehaviour {

	public Animator animator;
	public Animation anim;
	public JessesPlayerMovement movements;
	public GameObject Fire;
	public DialogueTrigger FirstConv;
	public CameraFollow cam;
	public GameObject FirstLight;
	public Transform Player;

	// Use this for initialization
	void Start () {
		animator.SetTrigger ("InitialAni");
		movements.Playtime = false;
		StartCoroutine (StartMove ());

	}

	IEnumerator StartMove()
	{
		yield return new WaitForSeconds (2f);
		Fire.SetActive (true);
		FirstConv.TriggerDialogue ();
		yield return new WaitForSeconds (9.0f);
		cam.Target = FirstLight.transform;
		yield return new WaitForSeconds (4.0f);
		cam.Target = Player;
		movements.Playtime = true;
		FirstConv.NextSentence ();
	}


}
