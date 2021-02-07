using UnityEngine.SceneManagement;
using UnityEngine;

public class AudioNow : MonoBehaviour
{
    // Start is called before the first frame update
    public string StopThis;
    public string PlayThis;
    private void Start() {
        if (StopThis != "")
        {
            FindObjectOfType<AudioManager>().Stop(StopThis);
        }
        FindObjectOfType<AudioManager>().Play(PlayThis);
    }
}