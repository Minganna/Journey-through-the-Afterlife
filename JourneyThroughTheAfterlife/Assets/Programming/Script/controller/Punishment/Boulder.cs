using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="crackedWall")
        {
            collision.gameObject.GetComponent<MeshCollider>().enabled = false;
            Destroy(collision.gameObject);

        }
    }
}
