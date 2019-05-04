using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightLight : MonoBehaviour {
    public GameObject Flashlight;
    public SettingsMenu FlashStart;
    bool time;

    void Update()
    {
        if (FlashStart.rightLightturn == true)
        {
            if (time)
            {
                Flashlight.SetActive(true);
                time = false;
                StartCoroutine(Flash());
            }

        }
        if (FlashStart.rightLightturn == false)
        {
            time = true;
            Flashlight.SetActive(false);
        }
    }


    IEnumerator Flash()
    {
        yield return new WaitForSeconds(1f);
        Flashlight.SetActive(false);
        yield return new WaitForSeconds(1f);
        Flashlight.SetActive(true);
        yield return new WaitForSeconds(1f);
        Flashlight.SetActive(false);
        yield return new WaitForSeconds(1f);
        Flashlight.SetActive(true);
        yield return new WaitForSeconds(1f);
        Flashlight.SetActive(false);
        yield return new WaitForSeconds(1f);
        Flashlight.SetActive(true);
        yield return new WaitForSeconds(1f);
        Flashlight.SetActive(false);
        yield return new WaitForSeconds(1f);
        Flashlight.SetActive(true);
        yield return new WaitForSeconds(1f);
        Flashlight.SetActive(false);
    }


    public void resetLight()
    {
        Flashlight.SetActive(false);
    }
}
