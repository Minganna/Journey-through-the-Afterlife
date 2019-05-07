using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour {

    public GameObject SettingsMenu;
    public GameObject Text;
    public GameObject Button;

    public void Instruction()
    {
        Text.SetActive(true);
        SettingsMenu.SetActive(false);
        Button.SetActive(true);
    }

    public void ComeBack()
    {
        Text.SetActive(false);
        SettingsMenu.SetActive(true);
        Button.SetActive(false);
    }
}
