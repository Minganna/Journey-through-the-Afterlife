using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class HealthBar : MonoBehaviour {

	public Slider healthBar;
	public Dissolve DissolveEnemy;
	public bool RemoveLifeGrass=false;
	public bool canAddLife=false;
	public bool RemoveLifeMeat=false;

	void Update () {
		if (DissolveEnemy.Addlife == 50) 
		{
			canAddLife = true;
		}
		if (DissolveEnemy.Addlife == 25) 
		{
			RemoveLifeGrass=true;
		}
		if (DissolveEnemy.Addlife == 0) 
		{
			RemoveLifeMeat=true;
		}
		if (RemoveLifeMeat == true) {
			healthBar.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left,0,160);
			healthBar.maxValue =50;
			healthBar.value = healthBar.maxValue;
			RemoveLifeMeat = false;
		}
		if (RemoveLifeGrass == true) {
			healthBar.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left,0,185);
			healthBar.maxValue =75;
			healthBar.value = healthBar.maxValue;
			RemoveLifeGrass = false;
			}
		if (canAddLife == true) {
			healthBar.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left,0,210);
			healthBar.maxValue = 100;
			canAddLife = false;

		}




		if (healthBar.maxValue <= 100) {
			healthBar.value += 1;
		}


	}



}
