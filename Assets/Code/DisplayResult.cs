using System.Collections;
using System.Collections.Generic;
using System;


using UnityEngine;
using UnityEngine.UI;


public class DisplayResult : MonoBehaviour
{
 
    private Dictionary<string, string> moleculas = new Dictionary<string, string>(){
        {"A0", "Etano"},
        {"A1", "Pentano"},
        {"A2", "Heptano"},

        {"B0", "Pentano"},
        {"B1", "Hexano"},
        {"B2", "Butano"},

        {"C0", "1-penteno"},
        {"C1", "1-hexeno"},
        {"C2", "1-hepteno"},

        {"D0", "1-pentino"},
        {"D1", "1-hexino"},
        {"D2", "1-heptino"},

        {"E0", "Butil"},
        {"E1", "Pentil"},
        {"E2", "Hexil"},

        {"F0", "2 metil Hexano"},
        {"F1", "2 metil Heptano"},
        {"F2", "2 metil Octano"},

        {"G0", "2 metil 1-Hexeno"},
        {"G1", "2 metil 1-Hepteno"},
        {"G2", "2 metil 1-Octeno"},

        {"H0", "3 metil 1-Heptino"},
        {"H1", "3 metil 1-Octino"},
        {"H2", "3 metil 1-Nonino"},

    };
 
    // Start is called before the first frame update
    void Start()
    {
        
        string result = @"
            Intentos: {0}
            -------------
            {1}       {2}
            -------------
            {3}       {4}
            -------------
            {5}       {6}
            -------------
        ";


        string mol1Key = String.Format("{0}0", Score.currentIndex);
        string mol2Key = String.Format("{0}1", Score.currentIndex);
        string mol3Key = String.Format("{0}2", Score.currentIndex);

        string mol1 = moleculas[mol1Key];
        string mol2 = moleculas[mol2Key];
        string mol3 = moleculas[mol3Key];

        string mol1Result = "X";
        string mol2Result = "X";
        string mol3Result = "X";

        if(Score.results[mol1Key] == Score.moleculas[mol1Key] ){
            mol1Result = "✓";
        }

        if(Score.results[mol2Key] == Score.moleculas[mol2Key] ){
            mol2Result = "✓";
        }

        if(Score.results[mol3Key] == Score.moleculas[mol3Key] ){
            mol3Result = "✓";
        }

        GameObject.Find("TextResult").GetComponentInChildren<Text>().text = String.Format(result, Score.tries, mol1, mol1Result, mol2, mol2Result, mol3, mol3Result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
