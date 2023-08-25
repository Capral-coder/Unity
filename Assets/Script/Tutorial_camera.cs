using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_camera : MonoBehaviour
{
    private int camera;
    private int location;
    public GameObject camera_location;
    [SerializeField] private Behaviour camera_go, camera_zoom;

    // Update is called once per frame
    void Update()
    {
        int cameraload = PlayerPrefs.GetInt("camera");
        camera = cameraload;

        if (camera == 2)
        {
            camera_go.enabled = false;
            camera_zoom.enabled = false;
        }
        else
        {
            camera_go.enabled = true;
            camera_zoom.enabled = true;
        }

        int locationload = PlayerPrefs.GetInt("location");
        location = locationload;
        if(location == 2)
        {
            transform.position = camera_location.transform.position;
        }
    }
}
