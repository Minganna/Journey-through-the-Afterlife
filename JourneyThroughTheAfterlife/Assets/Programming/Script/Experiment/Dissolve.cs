﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour {
	SkinnedMeshRenderer rend;
    bool GiveandTakeLife;
    float Threshold;
    bool Dissolving = false;
    bool GiveLife = false;
    GameObject Enemy;

    public bool CursorIsOver = false;



    // Update is called once per frame
    void Update () {
       
    if(GiveandTakeLife&&CursorIsOver)
        {
            GiveTakeLife();
        }
           
		if (Dissolving)
		{
			Threshold += 0.01f;
			rend.material.SetFloat("_Threshold", Threshold);
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
        if(collision.gameObject.tag=="PossibleToDissolve")
        {
            Enemy = GameObject.FindGameObjectWithTag("PossibleToDissolve");
			rend = Enemy.GetComponentInChildren<SkinnedMeshRenderer>();
			rend.material.shader = Shader.Find("Custom/Dissolve");
            GiveandTakeLife = true;
			return;
          
        }
		if(collision.gameObject.tag=="GhostCoin")
		{
			Enemy = GameObject.FindGameObjectWithTag("GhostCoin");
			rend = Enemy.GetComponentInChildren<SkinnedMeshRenderer>();
			rend.material.shader = Shader.Find("Custom/Dissolve");
			GiveandTakeLife = true;
			return;

		}
    }

    void OnTriggerExit(Collider other)
    {
        GiveandTakeLife = false;
    }
    }

