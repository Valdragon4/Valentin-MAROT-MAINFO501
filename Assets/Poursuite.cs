using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poursuite : MonoBehaviour
{
    public float speed = 0.02f;
    public GameObject Joueur;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject aggro = this.gameObject;
        Vector3 direction = Joueur.transform.position - aggro.transform.position;
        aggro.transform.rotation = Quaternion.LookRotation(-direction);
        aggro.transform.position += (speed * (direction)/direction.magnitude);
    }
}
