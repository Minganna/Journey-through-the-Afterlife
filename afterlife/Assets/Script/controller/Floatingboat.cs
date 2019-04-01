using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floatingboat : MonoBehaviour {

    private Transform SeaPlane;
    private Cloth PlaneCloth;
    private int closestVertexIndex = -1;

	// Use this for initialization
	void Start () {
        SeaPlane = GameObject.Find("Water").transform;
        PlaneCloth = SeaPlane.GetComponent<Cloth>();
	}
	
	// Update is called once per frame
	void Update () {
        GetClosestVertex();

    }

    void GetClosestVertex()
    {
        for(int i=0;i<PlaneCloth.vertices.Length;i++)
        {
            if(closestVertexIndex==-1)
            {
                closestVertexIndex = i;
            }
            float Distance = Vector3.Distance(PlaneCloth.vertices[1], transform.position);
            float ClosestDistance= Vector3.Distance(PlaneCloth.vertices[closestVertexIndex], transform.position);

            if(Distance<ClosestDistance)
            {
                closestVertexIndex = i;
            }
        }
        transform.localPosition = new Vector3(transform.localPosition.x, PlaneCloth.vertices[closestVertexIndex].y/5, transform.localPosition.z);
    }
}
