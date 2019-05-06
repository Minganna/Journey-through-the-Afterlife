using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Daniil_DialogueManager : MonoBehaviour {

	private Queue<string> sentences;
	public Text DialogueText;
	public Animator animator;


	// Use this for initialization
	void Start () {
		sentences = new Queue<string> ();
	}

	public void StartDialogue(Dialogue dialogue)
	{

		animator.SetBool ("IsOpen", true);
		Debug.Log ("Starting Dialogue");

		sentences.Clear ();

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue (sentence);
		}

		DisplayNextSentence ();

	}

	public void DisplayNextSentence()
	{
		if (sentences.Count == 0) {
			EndDialogue ();
			return;
		} 

		string sentence = sentences.Dequeue ();
	}

	IEnumerator TypeSentence(string sentence)
	{
		DialogueText.text = "";
		foreach (char letter in sentence.ToCharArray()) 
		{
			DialogueText.text += letter;
			yield return null;
		}	
	}

	void EndDialogue()
	{
		Debug.Log ("End Of Conversation");
		animator.SetBool ("IsOpen", false);
	}
}