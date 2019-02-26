using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class MeshGenerator : MonoBehaviour {

	Mesh mesh;

	Vector3[] vertices;
	int[] triangles;
    Color[] colors;
    Vector2[] uvs;

    float MinTerrainHeigh;
    float MaxTerrainHeigh;

    public int xSize=20;
	public int zSize=20;
    public Gradient gradient;



	// Use this for initialization
	void Start () {
		mesh= new Mesh();
		GetComponent<MeshFilter>().mesh=mesh;
        GetComponent<MeshCollider>().sharedMesh = mesh;
       

        CreateShape ();
        UpdateMesh();
    }

	
	void CreateShape()
	{
		vertices = new Vector3[(xSize + 1) * (zSize + 1)];

		for (int i=0, z = 0; z <= zSize; z++)
		{
			for (int x = 0; x <= xSize; x++)
			{
                float y = Mathf.PerlinNoise(x*0.3f, z*0.3f) * 2f;
				vertices [i] = new Vector3 (x, y, z);

                if(y>MaxTerrainHeigh)
                {
                    MaxTerrainHeigh = y;
                }
                if(y<MinTerrainHeigh)
                {
                    MinTerrainHeigh = y;
                }
				i++;
			}
		}

        int vert = 0;
        int tris = 0;
        triangles = new int[xSize * zSize * 6];
        for (int i = 0, z = 0; z < zSize; z++)
        {
            for (int x = 0; x < xSize; x++)
            {
                triangles[tris + 0] = vert + 0;
                triangles[tris + 1] = vert + xSize + 1;
                triangles[tris + 2] = vert + 1;
                triangles[tris + 3] = vert + 1;
                triangles[tris + 4] = vert + xSize + 1;
                triangles[tris + 5] = vert + xSize + 2;

                vert++;
                tris += 6;
            }
            vert++;
        }

        colors = new Color[vertices.Length];
        uvs = new Vector2[vertices.Length];

        for (int i = 0, z = 0; z <= zSize; z++)
        {
            for (int x = 0; x <= xSize; x++)
            {
                uvs[i] = new Vector2((float)x / xSize,(float) z / zSize);
                float height = Mathf.InverseLerp(MinTerrainHeigh,MaxTerrainHeigh, vertices[i].y);
                colors[i] = gradient.Evaluate(height);
                i++;
            }
        }


    }

	void UpdateMesh()
	{
		mesh.Clear ();

		mesh.vertices = vertices;
		mesh.triangles = triangles;
        mesh.uv = uvs;
        mesh.colors = colors;
		mesh.RecalculateNormals();
        GetComponent<MeshCollider>().enabled = true;
    }



}
