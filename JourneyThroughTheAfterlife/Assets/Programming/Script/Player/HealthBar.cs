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
			healthBar.maxValue =50;
			RemoveLifeMeat = false;
		}
		if (RemoveLifeGrass == true) {
			healthBar.maxValue =75;
			RemoveLifeGrass = false;
			}
		if (canAddLife == true) {
			healthBar.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left,0,100);
			healthBar.maxValue = 100;
			canAddLife = false;

		}




		if (healthBar.maxValue <= 100) {
			healthBar.value += 1;
		}


	}



}
