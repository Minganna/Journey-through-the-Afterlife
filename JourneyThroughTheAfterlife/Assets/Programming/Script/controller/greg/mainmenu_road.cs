﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenu_road : MonoBehaviour {


	public GameObject[] RoadComponents = new GameObject[10];
	const float RoadLength = 38f;

	[SerializeField]	const float RoadSpeed = 14f;

	
	// Update is called once per frame
	void Update () {
		foreach (GameObject road in RoadComponents)
		{
			Vector3 newRoadPos = road.transform.position;
			newRoadPos.z -= RoadSpeed * Time.deltaTime;
			if (newRoadPos.z < -RoadLength /2) 
			{
				newRoadPos.z += RoadLength;
			}
			road.transform.position = newRoadPos;

		}
	}
}
