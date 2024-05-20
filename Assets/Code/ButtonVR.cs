using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    bool isPressed;
    // Start is called before the first frame update
    void Start()
    {
     isPressed = false;   
    }

    private void OnTriggerEnter(Collider other){
        Debug.Log("Text");
        if(!isPressed){
        button.transform.localPosition = new Vector3(0, -0.704f, -0.8818f);
        presser = other.gameObject;
        onPress.Invoke();
        isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.gameObject == presser){
            button.transform.localPosition = new Vector3(0, -0.6934f, -0.8818f);
            onRelease.Invoke();
            isPressed = false;
        }
    }

    public void SpawnSphere(){
     Debug.Log("Text");   
    }
}
