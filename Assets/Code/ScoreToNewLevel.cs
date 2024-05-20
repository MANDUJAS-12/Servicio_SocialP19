using UnityEngine;
using System.Collections;
using System;

using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ScoreToNewLevel : MonoBehaviour
{
    float secondsLeft = 0;

    void Start()
    {
        StartCoroutine(DelayLoadLevel(5));
    }

    IEnumerator DelayLoadLevel(float seconds)
    {
        secondsLeft = seconds;
        do
        {
            GameObject.Find("Timer").GetComponentInChildren<Text>().text = String.Format("Cargando Nivel: {0}", secondsLeft);
            yield return new WaitForSeconds(1);
        } while (--secondsLeft > 0);

        Score.currentSceneId = Score.currentSceneId + 1;
        SceneManager.LoadScene(Score.currentSceneId);
    }

}