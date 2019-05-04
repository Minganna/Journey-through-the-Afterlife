using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftLight : MonoBehaviour {
    public GameObject Flashlight;
    bool time;
    public SettingsMenu FlashStart;

   void Update()
    {
        if (FlashStart.leftLightturn==true)
        {
            if (time)
            {
                Flashlight.SetActive(true);
                time = false;
                StartCoroutine(Flash());
            }

        }
        if (FlashStart.leftLightturn == false)
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
        yield return new WaitForSeconds(4f);
        Flashlight.SetActive(true);
        yield return new WaitForSeconds(1f);
        Flashlight.SetActive(false);
    }

    public void resetLight()
    {
        Flashlight.SetActive(false);
    }
}
