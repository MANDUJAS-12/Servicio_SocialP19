using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

using System;

public class Encima : MonoBehaviour
{

   public Dictionary<string, int> moleculas = new Dictionary<string, int>();
   public int molIndex;
   public string SceneNumber;
   // Start is called before the first frame update
   void Start() {

   }

   // Update is called once per frame
   void Update() {

   }

   void OnCollisionEnter (Collision collision) 
   {
      // int result;
      // if(!moleculas.TryGetValue(collision.gameObject.name, out result)){
      //    moleculas.Add(collision.gameObject.name, 1);
      // }

      // if(moleculas.TryGetValue("Agua", out result) && moleculas.TryGetValue("Ozono", out result)){
      //    SceneManager.LoadScene(3);
      // }
      Score.results.Add(collision.gameObject.name, molIndex);
      // GameObject.Find("Text").GetComponentInChildren<Text>().text = "";
      // foreach (var kvp in Score.results) {
      //    GameObject.Find("Text").GetComponentInChildren<Text>().text = String.Format("{0} {1}:{2}", GameObject.Find("Text").GetComponentInChildren<Text>().text, kvp.Key, kvp.Value);
         // GameObject.Find("Text").GetComponentInChildren<Text>().text = String.Format("Scene:{0} TableIndex:{1}", SceneNumber, molIndex);
      // }
   }

   void OnCollisionExit(Collision collision) {
      Score.results.Remove(collision.gameObject.name);
   }

}
