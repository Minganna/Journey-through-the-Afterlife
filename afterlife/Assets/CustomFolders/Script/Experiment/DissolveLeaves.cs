using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveLeaves : MonoBehaviour {

    private Renderer MyRendered;
    float Threshold;
    bool dissolvestarting = false;

    // Use this for initialization
    void Start () {
        MyRendered = gameObject.GetComponent<Renderer>();
        MyRendered.material.shader= Shader.Find("Custom/Dissolve");
        StartCoroutine(StartDissolving());
    }
	
	// Update is called once per frame
	void Update () {
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
