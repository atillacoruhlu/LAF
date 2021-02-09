using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject Kapi;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name[0]=='H') //If Holdable or Player enters
        {
            Kapi.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.gameObject.name[0]=='H') //If Holdable or Player exits
        {
            Kapi.SetActive(true);
        }
    }
}
