using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Daniil_ChangeScene : MonoBehaviour {

	public DialogueTrigger DialogueTrigger;

	void OnTriggerEnter(Collider other)
	{
		DialogueTrigger.TriggerDialogue();
	}

	void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player"&&Input.GetKeyDown(KeyCode.E))
		{
			SceneManager.LoadScene(3);
		}
	}
}