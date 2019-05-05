using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenu_meshkill : MonoBehaviour {

    public GameObject[] meshes;
    public GameObject position;

    public void DestroyMeshes()
    {
        foreach (GameObject mesh in meshes)
        {
            mesh.transform.position = position.transform.position;
        }
    }
}
