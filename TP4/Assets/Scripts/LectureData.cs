using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LectureData : MonoBehaviour
{
    public TextAsset jsonFile;
    public VisuData Visualize;
    public string country;
    private string countryPrec;
    void Start(){
        //clear all cubes
        Visualize.ClearCubes();

        Cities citiesInJson = JsonUtility.FromJson<Cities>(jsonFile.text);foreach (City cities in citiesInJson.cities){
            if(cities.country == country || country == "All"){
                Visualize.VisualCube(
                cities.lat,
                cities.lng,
                cities.population,
                Visualize.multiplier
                );
            }
        }
    }
    // Update is called once per frame
    void Update(){
        if(country != countryPrec){
            countryPrec = country;
            Start();}
    }

}