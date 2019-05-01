using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapManager : MonoBehaviour {

	public Animator MiniMapAnimator;
	bool open=false;

	public void OpenMinimap()
	{
		
		if (open == false) {
			MiniMapAnimator.SetBool ("IsOpen",true);
			open = true;
			return;
		}
		if (open == true) {
			MiniMapAnimator.SetBool ("IsOpen",false);
			open = false;
			return;
		}

	}


}
