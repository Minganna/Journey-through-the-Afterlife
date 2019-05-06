using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class HealthBar : MonoBehaviour {

	public Slider healthBar;
	public Dissolve DissolveEnemy;
	bool RemoveLifeGrass;
	bool canAddLife=false;
	bool RemoveLifeMeat=false;

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
		if (canAddLife == true) {
			healthBar.maxValue = 100;
			StartCoroutine (addRemovelife ());
			canAddLife = false;
		}
		if (RemoveLifeGrass == true) {
			healthBar.maxValue =75;
			StartCoroutine (addRemovelife ());
			RemoveLifeGrass = false;
		}
		if (RemoveLifeMeat == true) {
			healthBar.maxValue =50;
			StartCoroutine (addRemovelife ());
			RemoveLifeMeat = false;
		}
	}


	IEnumerator addRemovelife()
	{
		yield return new WaitForSeconds (1f);
		healthBar.value = healthBar.maxValue;
		
	}
}
