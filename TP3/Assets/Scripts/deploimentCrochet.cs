using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deploimentCrochet : MonoBehaviour
{
    public float vitesse = 5.0f; // Vitesse de déplacement du crochet
    public GameObject crochet; // Référence au crochet

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Détecter les entrées de clavier
        if (Input.GetKey(KeyCode.Y))
        {
            // Monter le crochet
            crochet.transform.position += Vector3.up * vitesse * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.U))
        {
            // Descendre le crochet
            crochet.transform.position += Vector3.down * vitesse * Time.deltaTime;
        }
    }
}