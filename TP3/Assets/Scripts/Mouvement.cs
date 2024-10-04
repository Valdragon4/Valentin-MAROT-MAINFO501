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
            speed = 0.005f;
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
        transform.Rotate(Vector3.forward, 1);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
        transform.Rotate(Vector3.back, 1);
        }
        GameObject Sol= GameObject.Find("Sol");
        if(Input.GetKeyDown(KeyCode.Space) && ((transform.position.y - Sol.transform.position.y) < 0.1f)){
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }

    }
}
