using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeavesManager : MonoBehaviour {

	public GameObject LeavesGroup1;
	public GameObject LeavesGroup2;
	public GameObject LeavesGroup3;
	public Collider[] Branches;
	public Collider[] Branches2;
	public Collider[] Branches3;

	public LeavesController nextGroup1;
	public LeavesController nextGroup2;

	// Use this for initialization
	void Start () {
		StartCoroutine(DestroyLeaves1());
	}
	
	// Update is called once per frame
	void Update () {
		if (nextGroup1.activate1 == true) {
			StartCoroutine(DestroyLeaves23(LeavesGroup2, Branches2));
		}
		if (nextGroup2.activate2 == true) {
			StartCoroutine(DestroyLeaves23(LeavesGroup3,Branches3));
		}

	}

	IEnumerator DestroyLeaves1()
	{
		
	
		yield return new WaitForSeconds(5f);
		Destroy (LeavesGroup1);
		foreach (Collider Branch in Branches) 
		{
			Branch.attachedRigidbody.useGravity=true;
			Branch.attachedRigidbody.constraints = RigidbodyConstraints.None;
		}

	}

	IEnumerator DestroyLeaves23(GameObject Leaves,Collider[]BranchesUsed)
	{
		yield return new WaitForSeconds(3f);
		Destroy (Leaves);
		foreach (Collider Branch in BranchesUsed) 
		{
			Branch.attachedRigidbody.useGravity=true;
			Branch.attachedRigidbody.constraints = RigidbodyConstraints.None;
		}

	}
}
