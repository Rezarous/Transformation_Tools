using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneGenerator : MonoBehaviour {


    public Transform point1;
    public Transform point2;
    public Transform point3;

    void Start()
    {
        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();
        Mesh thisMesh = gameObject.GetComponent<MeshFilter>().mesh;
        thisMesh.Clear();

        //Vector3[] verticesArray = { new Vector3(0, 0, 0), new Vector3(0, 1, 0), new Vector3(1, 1, 0) };
        Vector3[] verticesArray = { point1.position, point2.position, point3.position };
        thisMesh.vertices = verticesArray;

        Vector2[] uvArray = { new Vector2(0, 0), new Vector2(0, 1), new Vector2(1, 1) };

        int[] verticesOrder = { 0, 1, 2 };
        thisMesh.triangles = verticesOrder;

    }

    // Update is called once per frame
    void Update () {

        UpdateTriangle();

    }


    void UpdateTriangle(){
        Mesh thisMesh = gameObject.GetComponent<MeshFilter>().mesh;
        thisMesh.Clear();

        //Vector3[] verticesArray = { new Vector3(0, 0, 0), new Vector3(0, 1, 0), new Vector3(1, 1, 0) };
        Vector3[] verticesArray = { point1.position, point2.position, point3.position };
        thisMesh.vertices = verticesArray;

        Vector2[] uvArray = { new Vector2(0, 0), new Vector2(0, 1), new Vector2(1, 1) };

        int[] verticesOrder = { 0, 1, 2 };
        thisMesh.triangles = verticesOrder;
    }
}
