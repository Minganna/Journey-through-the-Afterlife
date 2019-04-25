using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daniil_HUD : MonoBehaviour {

	public GameObject MessagePanel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpenMessagePanel()
	{
		MessagePanel.SetActive (true);
	}

	public void CloseMessagePanel()
	{
		MessagePanel.SetActive (false);
	}
}
