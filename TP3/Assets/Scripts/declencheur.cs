using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class declencheur : MonoBehaviour
{
    public Text text;
    private int nbObjets = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.N)){
            Debug.Log("Nombre d'objets dans la zone de déclenchement : " + nbObjets);
        }
        
    }

    private void OnTriggerEnter(Collider other){
        nbObjets++;
        Debug.Log("Objet entré dans la zone de déclenchement");
        text.text = "Nombre d'objets dans la zone de déclenchement : " + nbObjets;

    }

    private void OnTriggerExit(Collider other){
        nbObjets--;
        Debug.Log("Objet sorti de la zone de déclenchement");
        text.text = "Nombre d'objets dans la zone de déclenchement : " + nbObjets;

    }
}
