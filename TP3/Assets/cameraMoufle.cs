using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMoufle : MonoBehaviour
{
    public Camera cam;
    public Terrain terrain;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float angle = terrain.terrainData.GetSteepness(cam.transform.position.x / terrain.terrainData.size.x, cam.transform.position.z / terrain.terrainData.size.z);
        cam.transform.rotation = Quaternion.Euler(90-angle, cam.transform.rotation.eulerAngles.y, cam.transform.rotation.eulerAngles.z);
    }
}
