using UnityEngine;

public class Exit : MonoBehaviour
{
    public string nextLevel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent != null)
        {
            if (other.transform.parent.name == "Player")
            {
                Initiate.Fade(nextLevel, Color.black, 2); //Loads credits
            }
        }
    }
}
