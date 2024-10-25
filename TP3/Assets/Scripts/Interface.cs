using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface : MonoBehaviour
{
    public float marche = 0.01f;
    public float sprint = 0.015f;
    public bool Visible =false;
    public float delai = 0.5f;
    private float temps = 0.0f;
    private float width_box = Screen.width/1.5f;
    private float height_box = Screen.height/1.5f;
    private float x = Screen.width/100;
    private float y = Screen.height/100;
    public GUIStyle style;
    public GUIStyle style2;

    void start(){
        style = new GUIStyle(GUI.skin.box);
        style2 = new GUIStyle(GUI.skin.label);
        style.fontSize = Screen.width/100;
        style.normal.textColor = Color.white;
        style2.fontSize = Screen.width/100;
        style2.normal.textColor = Color.white;
        style2.wordWrap = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)&& Time.time > temps + delai)
        {
            temps = Time.time;
            Visible = !Visible;
        }
    }

    void OnGUI()
    {

        if(Visible){
            GUI.Box(new Rect(x,y,width_box,height_box),"Commandes:");
            GUI.Label(new Rect(x+x/2,8*y,width_box/2.5f,height_box-y), "Deplacements: \n"+
            "fleches directionnelles pour deplacer la grue\n"+
            "Shift pour activer le sprint\n"+
            "O pour deplier les supports\n" +
            "P pour les replier\n"+
            "L pour abaisser les supports\n"+
            "M pour les remonter\n", style2);
            GUI.Label(new Rect(x+x/3+width_box/2,8*y,width_box/2.5f,height_box/2-y), "Bras: \n"+
            "monter le bras: W\n"+
            "descendre le bras: X\n"+
            "replier le bras: Z\n"+
            "deplier le bras: S\n", style2);
            GUI.Label(new Rect(x+x/3+width_box/2,10*y+height_box/3,width_box/2.5f,height_box-y), "Crochet: \n"+
            "descendre le crochet: Y\n"+
            "monter le crochet: U\n"+
            "lacher la charge: Espace\n", style2);

        }
        else{
            GUI.Box(new Rect(10, 10, Screen.width/4, Screen.height/10), "A pour afficher les commandes", style);
        }
    }
}