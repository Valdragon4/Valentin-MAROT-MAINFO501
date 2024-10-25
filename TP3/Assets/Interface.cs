using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface : MonoBehaviour
{

    private bool isDisplayed = false;
    private float ScreenWidth;
    private float ScreenHeight;
    public GUIStyle style = new GUIStyle();
    private Texture2D Background;
    // Start is called before the first frame update
    void Start()
    {
        ScreenWidth = Screen.width;
        ScreenHeight = Screen.height;
        style.fontSize = (int)(ScreenWidth / 75);
        style.normal.textColor = Color.white;
        Background = new Texture2D(1, 1);
        Background.SetPixel(0, 0, new Color(0, 0, 0, 0.5f));
        Background.Apply();
        style.normal.background = Background;
        style.wordWrap = true;
    }

    // Update is called once per frame
    void Update()
    {
        ScreenWidth = Screen.width;
        ScreenHeight = Screen.height;

        if(Input.GetKeyDown(KeyCode.Tab)){
            isDisplayed = !isDisplayed;
        }
    }

    void OnGUI(){
        if(!isDisplayed){
            GUI.Box( new Rect(1, 1, ScreenWidth/5, ScreenHeight/20), "Press tab to open commands", style);
        }else{
            GUI.Box( new Rect(1, 1, ScreenWidth/5,ScreenHeight/20), "Press tab to close commands", style);
            GUI.Box( new Rect(1,ScreenHeight/12+1, ScreenWidth/2,ScreenHeight/3), "Commands :" , style);
            GUI.Box( new Rect(1,ScreenHeight/7+1,ScreenWidth/5,ScreenHeight/7), "Movements : \n" + "Arrow up,down,left,right: move \n"
            + "Shift : boost movement speed \n", style);
            GUI.Box( new Rect(1,ScreenHeight/3.5f+1,ScreenWidth/5,ScreenHeight/10), "Camera : \n" + "C : change camera \n", style);
            GUI.Box( new Rect(1+ScreenWidth/5,ScreenHeight/7+1,ScreenWidth/3.5f,ScreenHeight/4.5f), "Crane action: \n" + "W, X: Up, Down \n" + "S, Z: Forward, Backward \n" + "Y, U: Hook up, Hook down \n" + "G, H: Left turn, Right turn \n" + "O, P: Deploy support, Retract support \n" + "L, M: Deploy second support, Retract second support \n", style);


        }
    }
}
