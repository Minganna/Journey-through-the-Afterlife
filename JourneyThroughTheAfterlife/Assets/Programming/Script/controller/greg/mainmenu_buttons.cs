using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu_buttons : MonoBehaviour {

    [SerializeField] bool greg_startgame = false;

    void Update()
    {
        if (greg_startgame)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void QuitGame()
    {
        Application.Quit();

    }
}
