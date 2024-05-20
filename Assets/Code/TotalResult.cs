using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;

using UnityEngine;
using UnityEngine.UI;


public class TotalResult : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {        
        string result = @"
            Mesa: {0}     Aciertos: {1}
            ---------------------------
        ";

        string[] tableIndex = new string[]{"A", "B", "C", "D", "E", "F", "G", "H"};

        GameObject.Find("TotalResultText").GetComponentInChildren<Text>().text = "";
        int total = 0;
        string mol1Key;
        string mol2Key;
        string mol3Key;
        foreach (int value in Enumerable.Range(0, 8))
        {

            mol1Key = String.Format("{0}0", tableIndex[value]);
            mol2Key = String.Format("{0}1", tableIndex[value]);
            mol3Key = String.Format("{0}2", tableIndex[value]);

            total = 0;

            if(Score.results[mol1Key] == Score.moleculas[mol1Key] ){
                total = total + 1;
            }

            if(Score.results[mol2Key] == Score.moleculas[mol2Key] ){
                total = total + 1;
            }

            if(Score.results[mol3Key] == Score.moleculas[mol3Key] ){
                total = total + 1;
            }
            GameObject.Find("TotalResultText").GetComponentInChildren<Text>().text = GameObject.Find("TotalResultText").GetComponentInChildren<Text>().text + String.Format(result, value + 1, total);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
