using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTop : MonoBehaviour {

    public CameraFollow cam;
    public int numb;
    public GameObject[] Targets;
    bool cutscene=false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player"&&numb==0)
        {
            cam.Offset = new Vector3(0, 10, 0);
        }
        if (other.tag == "Player" && numb == 1)
        {
            cam.Offset = new Vector3(0, 2, 10);
        }
        if (other.tag == "Player" && numb == 2)
        {
            cam.Offset = new Vector3(-10, 2, 0);
        }
        if (other.tag == "Player" && numb == 3)
        {
            cam.Offset = new Vector3(0, 2, 10);
        }
        if (other.tag == "Player" && numb == 5)
        {
            cam.Offset = new Vector3(0, 10, 10);
        }
    }


    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && numb == 4&&Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (cam.Offset.x <= 10)
            {
                cam.Offset += new Vector3(5, 0, 0);
            }
        }
        if (other.tag == "Player" && numb == 4 && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (cam.Offset.x >= -10)
            {
                cam.Offset += new Vector3(-5, 0, 0);
            }
        }

    }

    void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player" && numb == 1&&cutscene==false)
        {
            cutscene = true;
            cam.Target = Targets[0].transform;
            StartCoroutine(CheckNextTarget());

        }
    }

    IEnumerator CheckNextTarget()
    {
        yield return new WaitForSeconds(3f);
        cam.Offset = new Vector3(-10, 2, 0);
        cam.Target = Targets[1].transform;
        yield return new WaitForSeconds(3f);
        cam.Offset = new Vector3(0, 2, 10);
        cam.Target = Targets[2].transform;

    }
}
