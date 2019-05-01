using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveLeaves : MonoBehaviour {

    private Renderer MyRendered;
    float Threshold;
   public bool dissolvestarting = false;
    public int numbertree = 0;
   public  LeavesController wallcounter1;
  public  LeavesController wallcounter2;


    // Use this for initialization
    void Start () {
        MyRendered = gameObject.GetComponent<Renderer>();
        MyRendered.material.shader= Shader.Find("Custom/Dissolve");
        wallcounter1 = GameObject.FindGameObjectWithTag("wallone").GetComponent<LeavesController>();
        wallcounter2 = GameObject.FindGameObjectWithTag("walltwo").GetComponent<LeavesController>();
        if (numbertree == 0)
        {
            StartCoroutine(StartDissolving());
        }
      
    }
	
	// Update is called once per frame
	void Update () {
        if (wallcounter1.activate1 == true && numbertree == 1)
        {
            dissolvestarting = true;
        }
        if (wallcounter2.activate2 == true && numbertree == 2)
        {
            dissolvestarting = true;
        }
        if (dissolvestarting)
        {
            Threshold += 0.001f;
            MyRendered.material.SetFloat("_Threshold", Threshold);
        }
    }

    IEnumerator StartDissolving()
    {
        yield return new WaitForSeconds(2f);
        dissolvestarting = true;
	


    }
}
