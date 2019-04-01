using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCursor : MonoBehaviour {

    GameObject Player;
    Dissolve DissolveScript;
    
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        DissolveScript = Player.GetComponent<Dissolve>();
    }
    // Use this for initialization
    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        Debug.Log("Mouse is over GameObject.");
        DissolveScript.CursorIsOver = true;
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on GameObject.");
        DissolveScript.CursorIsOver = false;
    }
}
