using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenu_ground : MonoBehaviour {

    public GameObject[] GroundComponents = new GameObject[3];
    const float GroundLength = 118f;

    public float GroundSpeed = 14f;


    // Update is called once per frame
    void Update()
    {
        foreach (GameObject Ground in GroundComponents)
        {
            Vector3 newGroundPos = Ground.transform.position;
            newGroundPos.z -= GroundSpeed * Time.deltaTime;
            if (newGroundPos.z < -GroundLength / 2)
            {
                newGroundPos.z += GroundLength;
            }
            Ground.transform.position = newGroundPos;

        }
    }
}

