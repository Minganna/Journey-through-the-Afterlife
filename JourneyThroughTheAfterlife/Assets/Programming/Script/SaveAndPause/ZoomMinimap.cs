using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomMinimap : MonoBehaviour {


	public Camera minimapCamera;
	float zoom;

	void Start()
	{
		zoom=minimapCamera.orthographicSize;
	}

	void Update()
	{
		minimapCamera.orthographicSize = zoom;
	}
	public void MinusZoom()
	{

	
			zoom += 10;	


	}
	public void PlusZoom()
	{
	if (zoom > 9.5) {
		zoom -= 10;	
		}
	}
}
