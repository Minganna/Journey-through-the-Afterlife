using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTopView : MonoBehaviour {

    public CameraFollow cam;
    public DialogueTrigger diatri;

void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            cam.Offset = new Vector3(0, 30, 0);
        }
    }


void OnTriggerExit(Collider other)
{
    if (other.tag == "Player")
    {
        cam.Offset = new Vector3(0, 2, 10);
            diatri.TriggerDialogue();
            StartCoroutine(DialogueClose());
    }
}

    IEnumerator DialogueClose()
    {
        yield return new WaitForSeconds(3f);
        diatri.NextSentence();
    }
}
