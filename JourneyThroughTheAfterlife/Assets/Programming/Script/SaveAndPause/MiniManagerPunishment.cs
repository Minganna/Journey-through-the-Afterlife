using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniManagerPunishment : MonoBehaviour {

    public DialogueTrigger diatri;
    public MiniMapScript mpm;
    public Transform Light;
    public GameObject PlayerLight;
    public Transform Player;
    bool target=false;


	// Use this for initialization
	void Start () {
        diatri.TriggerDialogue();
        StartCoroutine(MiniMapInstructions());
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && target == true)
        {
            mpm.player = Player;
            target =false;
            PlayerLight.SetActive(false);
            return;
        }

        if (Input.GetKeyDown(KeyCode.E)&&target==false)
        {
            mpm.player = Light;
            target = true;
            PlayerLight.SetActive(true);
            return;
        }

	}

    IEnumerator MiniMapInstructions()
    {
        yield return new WaitForSeconds(2f);
        diatri.NextSentence();
        yield return new WaitForSeconds(2f);
        diatri.NextSentence();
    }

}
