using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Move : MonoBehaviour
{
    public GameObject lastHit;
    public Vector3 collision = Vector3.zero;
    public XRDirectInteractor rHand;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var ray = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit)){
            lastHit = hit.transform.gameObject;
            collision = hit.point;
            // lastHit.SendMessage("OnDetectionArea",null, SendMessageOptions.DontRequireReceiver);
          
        }
    }
}
