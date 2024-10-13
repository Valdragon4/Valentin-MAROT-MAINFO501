using UnityEngine;
using System.Collections;

public class onload : MonoBehaviour {



    public GameObject cubeBottom;
    public GameObject cubeTop;


    void Start ()
    {

        LineRenderer lineRenderer = GetComponent<LineRenderer> ();

        lineRenderer.SetPosition (0, cubeBottom.transform.localPosition);
        lineRenderer.SetPosition (1, cubeTop.transform.localPosition);
        lineRenderer.endWidth = 0.1f;
        lineRenderer.startWidth = 0.1f;
        lineRenderer.material.color = Color.black;

    }

    void Update ()
    {

    }

}