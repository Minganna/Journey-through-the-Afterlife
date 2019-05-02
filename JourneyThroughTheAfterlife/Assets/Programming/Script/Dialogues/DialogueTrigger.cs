using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

	public Dialogue dialogue;
	public DialogueManager Manager;


		

	public void TriggerDialogue ()
	{
		FindObjectOfType<DialogueManager> ().StartDialogue (dialogue);
			}


	public void NextSentence()
	{

	 	Manager.DisplayNextSentence();

	}
}
