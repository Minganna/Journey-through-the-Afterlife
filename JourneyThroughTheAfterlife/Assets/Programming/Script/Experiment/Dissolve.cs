using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour {
	SkinnedMeshRenderer rend;
    bool GiveandTakeLife;
    float Threshold;
    bool Dissolving = false;
    bool GiveLife = false;
    GameObject Enemy;
	public Animator animator;
	public DialogueTrigger dialogue;
	public GameObject Coin;


    public bool CursorIsOver = false;



    // Update is called once per frame
    void Update () {

		if (Threshold > 2f) {

			Coin.transform.parent = null;
			Destroy (Enemy);
		}
       
    if(GiveandTakeLife&&CursorIsOver)
        {
            GiveTakeLife();
        }
           
		if (Dissolving)
		{
			if (Enemy != null) {
				animator.SetBool ("IsDying", true);

			Threshold += 0.01f;
			rend.material.SetFloat("_Threshold", Threshold);
			dialogue.NextSentence ();
			}
		}
    }

	void OnMouseOver()
	{
		Debug.Log (gameObject.name);
	}


    void GiveTakeLife()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Dissolving = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Dissolving = false;
        }
        if (Input.GetMouseButtonDown(1))
        {
            GiveLife = true;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            GiveLife = false;
        }
      
        else if (GiveLife)
        {
            Threshold -= 0.001f;
			rend.material.SetFloat("_Threshold", Threshold);
        }
    }
    void OnTriggerStay(Collider collision)
    {
		if(collision.gameObject.tag=="GhostCoin")
		{

				Enemy = GameObject.FindGameObjectWithTag ("GhostCoin");
			if (Enemy != null) {
				rend = Enemy.GetComponentInChildren<SkinnedMeshRenderer> ();
				rend.material.shader = Shader.Find ("Custom/Dissolve");
			}
			GiveandTakeLife = true;
			return;

		}
    }

    void OnTriggerExit(Collider other)
    {
        GiveandTakeLife = false;
    }
    }

