using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeSight : MonoBehaviour {

    public Dissolve dissolve;
    public DialogueTrigger diatri;
    public CameraFollow cam;
    bool spot=false;
    public GameObject[] Player;
   

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player"&&dissolve.CanBeSpotted==true)
		{
            if (spot == false)
            {
                diatri.TriggerDialogue();
                StartCoroutine(CheckPoint());
            }
		}

	}

    IEnumerator CheckPoint()
    {
        yield return new WaitForSeconds(2f);
        diatri.NextSentence();
        Player[0].transform.position = Player[1].transform.position;
        cam.Offset = new Vector3(-10, 4, 0);

    }
}
