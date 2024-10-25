using UnityEngine;

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
    }

}