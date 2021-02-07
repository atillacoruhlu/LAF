using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anahtar : MonoBehaviour
{
    public GameObject Kapi;
    private void OnTriggerEnter(Collider other) {
        if(other.transform.parent.name=="Player")
        {
            Destroy(Kapi);
            Destroy(gameObject);
        }
    }
}
