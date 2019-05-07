using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToHospital : MonoBehaviour {

    public MotherDialogue fatherfinal;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(fatherfinal.changeSceneFinal==true)
        {
            SceneManager.LoadScene(5);
        }
		
	}
}
