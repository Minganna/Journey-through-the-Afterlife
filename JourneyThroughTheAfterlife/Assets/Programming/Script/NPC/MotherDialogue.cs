using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherDialogue : MonoBehaviour {

    public CameraFollow cam;
    public DialogueTrigger diatri;
    public GameObject Mother;
    public GameObject name;
    public GameObject Player;
    public JessesPlayerMovement movement;
    public bool cutscene=true;
    public bool changeSceneFinal=false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (cutscene == true)
            {
                movement.Playtime = false;
            name.SetActive(true);
            cam.Target = Mother.transform;
            diatri.TriggerDialogue();

                cutscene = false;
                StartCoroutine(DialogueClose());

            }
            
        }
    }



    IEnumerator DialogueClose()
    {
        yield return new WaitForSeconds(5f);
        diatri.NextSentence();
        yield return new WaitForSeconds(5f);
        diatri.NextSentence();
        yield return new WaitForSeconds(5f);
        diatri.NextSentence();
        cam.Target = Player.transform;
        movement.Playtime = true;
        changeSceneFinal = true;

    }
}
