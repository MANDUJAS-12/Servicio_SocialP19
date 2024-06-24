using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;

using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;


public class Score : MonoBehaviour
{
    
    public static Dictionary<string, int> moleculas = new Dictionary<string, int>(){
        {"A0",0},
        {"A1", 1},
        {"A2", 2},
        {"A3", 3},

        {"B0", 0},
        {"B1", 1},
        {"B2", 2},

        {"C0", 0},
        {"C1", 1},
        {"C2", 2},

        {"D0", 0},
        {"D1", 1},
        {"D2", 2},

        {"E0", 0},
        {"E1", 1},
        {"E2", 2},

        {"F0", 0},
        {"F1", 1},
        {"F2", 2},

        {"G0", 0},
        {"G1", 1},
        {"G2", 2},

        {"H0", 0},
        {"H1", 1},
        {"H2", 2},

    };

    public static Dictionary<string, int> results = new Dictionary<string, int>();
    public static int tries = 0;
    public static string currentIndex;
    public static int currentSceneId = 1;

    void Start() {
    }

    void Update(){
    }

    public static bool LevelOK(int sceneID, string currentIndex) {
        string key;
        bool good = true;
        
        int result;
        int molecula;
        GameObject.Find("Text").GetComponentInChildren<Text>().text = "";
        foreach (int value in Enumerable.Range(0, 3))
        {
            key = String.Format("{0}{1}", currentIndex, value);
            moleculas.TryGetValue(key, out molecula);
            results.TryGetValue(key, out result);
            // string current = GameObject.Find("Text").GetComponentInChildren<Text>().text;
            // GameObject.Find("Text").GetComponentInChildren<Text>().text = String.Format("{0} key:{1} Result:{2} Mol:{3}", current, key, result, molecula);
            if(molecula != result){
                good = false;
                break;
            }
        }
        // GameObject.Find("Text").GetComponentInChildren<Text>().text = String.Format("{0} {1}",GameObject.Find("Text").GetComponentInChildren<Text>().text, good);
        return good;
    }
}
