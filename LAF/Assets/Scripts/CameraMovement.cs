using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float smoother = 0.125f;

    public Camera camera_obj;
    Color dark_camera_color = new Color(0.2265f,0.2265f,0.2265f,1.0f);

    void Start()
    {
        //To make camera DARK after 4000 mark.
        if (PlayerPrefs.GetInt("DarkMode", 0) != 0) //If DarkCamera is active
        {
            camera_obj = GetComponent<Camera>(); //Get the camera
            camera_obj.backgroundColor = Color.Lerp(camera_obj.backgroundColor, dark_camera_color, 1f);

            //TO MAKE FOG DARK
            RenderSettings.fogColor = dark_camera_color;
        }
    }

    void FixedUpdate()
    {
        Vector3 desiredPos = player.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPos, smoother);
        transform.position = smoothPos;

        transform.LookAt(player);
    }
}