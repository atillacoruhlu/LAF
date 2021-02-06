using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tentacle : MonoBehaviour
{
    private GameObject Parent;
    public GameObject TouchedObject;
    private void Awake() {
        Parent=gameObject.transform.parent.gameObject;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.name==gameObject.name)
        {
          TouchedObject=other.transform.parent.gameObject; 
        }
    }
    private void OnTriggerExit(Collider other) {
        TouchedObject=null;
    }
}
