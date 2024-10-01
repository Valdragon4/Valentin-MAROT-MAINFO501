using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        float speed = 0.01f;
        if(Input.GetKey(KeyCode.LeftShift)){
            speed = 0.05f;
        }
        if (Input.GetKey(KeyCode.DownArrow)){
        transform.Translate(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
        transform.Translate(Vector3.back * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
        transform.Rotate(Vector3.up, -2);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
        transform.Rotate(Vector3.up, 2);
        }
        GameObject Sol= GameObject.Find("Sol");
        if(Input.GetKeyDown(KeyCode.Space) && ((transform.position.y - Sol.transform.position.y) < 0.1f)){
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }

    }
}
