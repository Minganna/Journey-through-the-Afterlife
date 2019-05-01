using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

	public Dialogue dialogue;
	public DialogueManager Manager;


	void Update()
	{
		NextSentence ();
	}


	public void TriggerDialogue ()
	{
		FindObjectOfType<DialogueManager> ().StartDialogue (dialogue);
			}


	void NextSentence()
	{
		if (Input.GetKeyDown(KeyCode.E))
			{
				Manager.DisplayNextSentence();
			}

	}
}
