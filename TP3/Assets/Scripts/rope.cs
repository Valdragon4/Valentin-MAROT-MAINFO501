using UnityEngine;

<<<<<<< HEAD
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
=======
public class rope : MonoBehaviour
{
    public Transform moufle;
    public Transform crochet;
    public LineRenderer lineRenderer;
    private Vector3[] bezierPoints = new Vector3[4];

    void Start()
    {
        lineRenderer.startWidth = 0.01f;
        lineRenderer.endWidth = 0.01f;
        lineRenderer.positionCount = 2;
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        lineRenderer.startColor = Color.black;
        lineRenderer.endColor = Color.black;
    }

    void Update()
    {
        lineRenderer.SetPosition(0, moufle.position);
        lineRenderer.SetPosition(1, crochet.position);
>>>>>>> 635171c0fe0b7007c81f88373a2620c9ac89cddf
    }

}