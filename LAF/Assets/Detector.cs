using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    public GameObject TouchedObject;
    private void OnTriggerEnter(Collider other) 
    {
        if (other.name!="Anahtar"&&other.name!="Exit")
        {
            TouchedObject=other.transform.parent.gameObject; 
        }
        

    }
    private void OnTriggerExit(Collider other) {
        if (other.name!="Anahtar"&&other.name!="Exit")
        {
            TouchedObject=null;
        }
        
    }
}
