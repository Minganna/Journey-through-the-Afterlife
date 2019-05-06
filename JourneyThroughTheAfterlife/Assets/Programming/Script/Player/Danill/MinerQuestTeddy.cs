using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinerQuestTeddy : MonoBehaviour {
	GameObject QuestItem;
	bool QuestDone = false;
	public Animator _animator;

	// Update is called once per frame
	void Update () {
		if (QuestDone == true) {
			Destroy (GameObject.FindGameObjectWithTag("DeletePadlock"));
			_animator.SetBool ("Open", true);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.name == "Teddy_Textured") {
			QuestDone = true;
			Destroy (other.gameObject);

		}
	}
}
