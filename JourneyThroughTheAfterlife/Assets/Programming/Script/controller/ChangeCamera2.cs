using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera2 : MonoBehaviour {

	public CameraFollow cam;
    public DialogueTrigger trigdi;
    public GameObject CryingGhost1;
    public Daniil_PlayerMovement movements;
    public Daniil_PlayerRotation rotations;
    public GameObject Grass;
    public GameObject Player;
    bool dialoguedone=false;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			cam.Offset = new Vector3 (-10, 4, 0);
		}
	}
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player"&&dialoguedone==false)
        {
            trigdi.TriggerDialogue();
            movements.Playtime = false;
            rotations.Playtime = false;
            cam.Target = CryingGhost1.transform;
            StartCoroutine(Instructions());

        }
    }


    IEnumerator Instructions()
    {
        yield return new WaitForSeconds(3f);
        cam.Offset = new Vector3(0, 2, +10);
        cam.Target = Grass.transform;
        trigdi.NextSentence();
        yield return new WaitForSeconds(5f);
        dialoguedone = true;
        yield return new WaitForSeconds(3f);
        trigdi.NextSentence();
        cam.Target = Player.transform;
        movements.Playtime = true;
        rotations.Playtime = true;
        cam.Offset = new Vector3(-10, 4, 0);

    }
}
