using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycasttoNPC : MonoBehaviour {

	RaycastHit hitNPC=new RaycastHit();
	public GameObject GhostwithCoin;
	public CameraFollow changeoffset;
	public DialogueTrigger trigdia;
	public Transform Player;
	bool checkGhost=true;
	public Dissolve dissolve;

	bool changeBackCamera=true;
	

	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		LayerMask mask = LayerMask.NameToLayer ("CameraSearch");
	
			if (Physics.Raycast (ray, out hitNPC, 100f, mask)) {
				Debug.Log (hitNPC.transform.name);
				dissolve.CursorIsOver = true;
				if (hitNPC.transform.tag == "GhostCoin") {
				if (checkGhost == true) {
					GhostwithCoin = hitNPC.transform.gameObject;
					changeoffset.Target = GhostwithCoin.transform;
					Debug.Log ("GhostFound");
					StartCoroutine (ReturnToPlayer ());
				}

				} else {
					GhostwithCoin = null;
					dissolve.CursorIsOver = false;
				}

		}
}


	IEnumerator ReturnToPlayer()
	{
		if (changeBackCamera)
		{
			changeBackCamera = false;
			trigdia.NextSentence ();
			yield return new WaitForSeconds (5.0f);
			trigdia.NextSentence ();
			changeoffset.Target = Player.transform;
			checkGhost = false;

		}
	}

}
