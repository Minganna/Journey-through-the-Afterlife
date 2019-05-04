using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLight : MonoBehaviour {

    public GameObject RedLights;

    public void RedLightsON()
    {
        RedLights.SetActive(true);
    }
}
