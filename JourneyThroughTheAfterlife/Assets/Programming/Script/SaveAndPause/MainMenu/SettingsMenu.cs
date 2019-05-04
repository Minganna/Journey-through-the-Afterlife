using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SettingsMenu : MonoBehaviour {

    public mainmenu_road road;
    bool stoproad=false;
    public GameObject StopSign;
    public GameObject StopLights;
    public GameObject[] Menus;
    public GameObject[] roads;
    public CameraMenu cam;
    bool bugfix=true;
    public bool leftLightturn=false;
    public bool rightLightturn=false;

   

    void Update()
    {
        if (stoproad == true && road.RoadSpeed > 0)
        {
            road.RoadSpeed -= 0.1f;
            StopLights.SetActive(true);
            if (road.RoadSpeed  <1.5)
            {
                StopSign.SetActive(true);
            }
            if (road.RoadSpeed < 0.2)
            {
                StopLights.SetActive(false);
                Menus[0].SetActive(false);
                Menus[2].SetActive(false);
                roads[2].SetActive(false);
                if (bugfix == true)
                {
                    bugfix = false;
                    StartCoroutine(ChangeCameramenus());
                }
                
            }
        }

        if (stoproad == false && road.RoadSpeed < 14)
        {
            Menus[0].SetActive(true);
            Menus[2].SetActive(true);
            roads[0].SetActive(true);
            roads[1].SetActive(false);
            roads[2].SetActive(true);
            StopSign.SetActive(false);
            Menus[1].SetActive(false);
            road.RoadSpeed += 0.1f;
        }

            IsMouseOverUIIgnores();

       
        }

    IEnumerator ChangeCameramenus()
    {
        yield return new WaitForSeconds(1f);
        roads[0].SetActive(false);
        roads[1].SetActive(true);
        cam.stop = true;
        yield return new WaitForSeconds(3f);
        Menus[1].SetActive(true);
    }

    public void OpenSettings()
    {
        stoproad = true;

    }

    public void BackToMenu()
    {
        cam.stop = false;
        stoproad = false;
    }

    private bool IsMouseOverUIIgnores()
    {
        PointerEventData pointer = new PointerEventData(EventSystem.current);
        pointer.position = Input.mousePosition;

        List<RaycastResult> raycastresultlist = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointer,raycastresultlist);
        for (int i=0;i<raycastresultlist.Count;i++)
        {
            if (raycastresultlist[i].gameObject.GetComponent<LeftLight>()!=null)
            {
                leftLightturn = true;
                rightLightturn = false;
                raycastresultlist.RemoveAt(i);
                i--;
            }

            if (raycastresultlist[i].gameObject.GetComponent<RightLight>() != null)
            {
                leftLightturn = false;
                rightLightturn = true;
                raycastresultlist.RemoveAt(i);
                i--;
            }


        }
        return raycastresultlist.Count > 0;


    }
}
