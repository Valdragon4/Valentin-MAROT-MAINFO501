using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbite : MonoBehaviour
{

    public GameObject cible;
    public float anglesParSeconde = 45f;
    public float anglesSouris = 90f;
    public bool rotationActive = true;
    void Start(){
        this.transform.transform.position = new Vector3(2, 0, 0);this.transform.transform.rotation = Quaternion.Euler(0,-90f,0);
    }
    
    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            rotationActive = !rotationActive;
        }
        if (rotationActive){
            Rotation();
        }else{
            RotationManuelle();
        }
    }

    void Rotation(){
        float angle = anglesParSeconde * Time.deltaTime;
        this.transform.RotateAround(cible.transform.position, Vector3.up, angle);
    }

    void RotationManuelle(){
        float angle = anglesSouris * Time.deltaTime;
        if (Input.GetMouseButton(0)){
            this.transform.RotateAround(cible.transform.position, Vector3.up, angle * Input.GetAxis("Mouse X"));
            this.transform.RotateAround(cible.transform.position, this.transform.right, -angle * Input.GetAxis("Mouse Y"));
        }
    }
}
