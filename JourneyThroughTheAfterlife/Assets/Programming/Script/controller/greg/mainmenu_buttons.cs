using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu_buttons : MonoBehaviour {

    public bool loadingScene = false;

    public void QuitGame()
    {
        Application.Quit();
    }

    void Update()
    {
        if (loadingScene)
        {
            SceneManager.LoadScene(1);
        }
    }
}
