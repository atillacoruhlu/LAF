using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public Camera menuCamera;

    private void Awake () {
        Instantiate (menuCamera, new Vector3 (0, 0, 0), Quaternion.identity);
    }
    public void PlayButton () {
        Initiate.Fade ("Level01", Color.black, 2); //Loads 01
    }

    public void SelectButton (string parametre) {
        Initiate.Fade (parametre, Color.black, 2); //Loads level
    }
    public void LevelSelectButton () {
        Initiate.Fade ("LevelSelectScene", Color.black, 2); //Loads levelselect
    }

    public void InfoButton () {
        Initiate.Fade ("CreditsScene", Color.black, 2); //Loads credits
    }

    public void ExitGame () {
        Application.Quit (); //Stops existing
    }
}