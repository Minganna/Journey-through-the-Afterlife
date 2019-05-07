using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player"&&Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(4);
        }
    }
}
