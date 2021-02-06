using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    public GameObject TouchedObject;
    private void OnTriggerEnter(Collider other) 
    {
        TouchedObject=other.transform.parent.gameObject; 

    }
    private void OnTriggerExit(Collider other) {
        TouchedObject=null;
    }
}
