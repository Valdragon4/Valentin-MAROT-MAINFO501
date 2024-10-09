using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePatte : MonoBehaviour
{
    
    //l'articulation est initialis�e en mode Fixe pour �tre "au repos"
    public EtatRotation rotationState = EtatRotation.Fixe;
    //vitesse de rotation par d�faut, public siginifie qu'elle peut �tre modifi�e dans l'inspecteur
    public float speed = 30.0f;

    private ArticulationBody articulation;

    void Start()
    {
        articulation = GetComponent<ArticulationBody>();
    }

    void FixedUpdate() //FixedUpdate est comme Update, mais synchronis� avec le moteur physique d'unity
    {

        if (rotationState != EtatRotation.Fixe)
        {
            float rotationChange = (float)rotationState * speed * Time.fixedDeltaTime;
            float rotationGoal = CurrentPrimaryAxisRotation() + rotationChange;
            RotateTo(rotationGoal);
        }
    }
    

    float CurrentPrimaryAxisRotation()
    {
        float currentRotationRads = articulation.jointPosition[0];
        float currentRotation = Mathf.Rad2Deg * currentRotationRads;
        return currentRotation;
    }

    void RotateTo(float primaryAxisRotation)
    {
        var drive = articulation.xDrive;
        drive.target = primaryAxisRotation;
        articulation.xDrive = drive;
    }
}
