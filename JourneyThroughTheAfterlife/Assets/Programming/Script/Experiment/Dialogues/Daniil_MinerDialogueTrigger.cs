using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daniil_MinerDialogueTrigger : MonoBehaviour {
	public DialogueTrigger StartDialogue;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			StartDialogue.TriggerDialogue ();
		}
	}

	void OnTriggerExit()
	{
		StartDialogue.NextSentence ();
	}
}
