using UnityEngine;
public class rope : MonoBehaviour {



    public GameObject cubeBottom;
    public GameObject cubeTop;
    public LineRenderer lineRenderer;


    void Start ()
    {
        lineRenderer.material = new Material (Shader.Find ("Sprites/Default"));
        lineRenderer.startColor = Color.black;
        lineRenderer.endColor = Color.black;
        lineRenderer.startWidth = 0.02f;
        lineRenderer.endWidth = 0.02f;
        lineRenderer.positionCount = 2;

    }

    void Update ()
    {  
        lineRenderer.SetPosition (0, cubeBottom.transform.position);
        lineRenderer.SetPosition (1, cubeTop.transform.position);
    }

}