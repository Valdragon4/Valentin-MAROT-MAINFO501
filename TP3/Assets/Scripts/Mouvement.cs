using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour
{

    public GameObject Roues;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        float speed = 0.001f;
        if(Input.GetKey(KeyCode.LeftShift)){
            speed = 0.008f;
        }

        //On fait tourner une roue
        if (Input.GetKey(KeyCode.DownArrow)){
        Roues.transform.Translate(Vector3.down * speed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
        Roues.transform.Translate(Vector3.up * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
        transform.Rotate(Vector3.forward, 0.1f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
        transform.Rotate(Vector3.back, 0.1f);
        }
    }
}
