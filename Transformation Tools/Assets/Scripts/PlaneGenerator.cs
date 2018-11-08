using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneGenerator : MonoBehaviour {


    public Transform point0;
    public Transform point1;
    public Transform point2;
    public Transform point3;
    public Material thisMat;

    void Start()
    {
        //gameObject.AddComponent<MeshFilter>();
        //gameObject.AddComponent<MeshRenderer>();
        UpdateTriangle();

    }


    void Update () {

       UpdateTriangle();

    }


    void UpdateTriangle(){
        Mesh thisMesh = gameObject.GetComponent<MeshFilter>().mesh;
        thisMesh.Clear();

        Vector3[] verticesArray = { point0.position, point1.position, point2.position, point3.position };
        thisMesh.vertices = verticesArray;

        Vector2[] uvArray = { new Vector2(0, 0), new Vector2(0, 1), new Vector2(1, 1), new Vector2(1, 0) };

        int[] verticesOrder = {
            0, 1, 2,
            0, 2, 3};
        thisMesh.triangles = verticesOrder;
        thisMesh.uv = uvArray;
    }
}
