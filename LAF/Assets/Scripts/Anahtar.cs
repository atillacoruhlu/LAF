using UnityEngine;

public class Anahtar : MonoBehaviour
{
    public GameObject Kapi;
    private void Update() {
        gameObject.transform.Rotate(0, 0, +1);
    }
    private void OnTriggerEnter(Collider other) {
        if(other.transform.parent.name=="Player")
        {
            Destroy(Kapi);
            Destroy(gameObject);
        }
    }
}
