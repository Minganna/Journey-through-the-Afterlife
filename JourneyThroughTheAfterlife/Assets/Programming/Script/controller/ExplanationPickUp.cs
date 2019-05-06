using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplanationPickUp : MonoBehaviour {

	public DialogueTrigger diatri;
	public Dissolve dissolve;
	public bool[] cancontinue;


	void OnTriggerEnter()
	{
		if (cancontinue[0] == false) {
			diatri.TriggerDialogue ();
			cancontinue[0] = true;
		}

	}

	void Update()
	{
		if(Input.GetMouseButtonDown(1)&&cancontinue[0]==true)
			{
			diatri.NextSentence ();
			cancontinue [1] = true;
			cancontinue [0] = false;
			}
		if (Input.GetKeyDown (KeyCode.E)&&cancontinue[1]==true) 
		{
			diatri.NextSentence ();

		}
		if (Input.GetKeyDown (KeyCode.Q)) 
		{
			diatri.NextSentence ();
		}

	}


}
