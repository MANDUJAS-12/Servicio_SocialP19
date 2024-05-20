using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    public bool noCheck = true;
    public string currentIndex;
    public void MoveToScene(int sceneID) {
        Score.tries = Score.tries + 1;
        if(Score.LevelOK(sceneID, currentIndex) || Score.tries == 2 || noCheck){
            if(noCheck) {
                SceneManager.LoadScene(sceneID);
                Score.tries = 0;
                Score.currentSceneId = Score.currentSceneId + 1;
            } else {
                Score.currentIndex = currentIndex;
                SceneManager.LoadScene(18);
            }
        } else {
            SceneManager.LoadScene(sceneID-1);
        }
    }
}

