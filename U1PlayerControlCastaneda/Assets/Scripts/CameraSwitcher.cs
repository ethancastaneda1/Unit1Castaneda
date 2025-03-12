using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera Cam1;
    public Camera Cam2;
    // Start is called before the first frame update
    void Start()
    {
        // initall requried state of cameras
        Cam1.enabled = false;
        Cam2.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            Cam1.enabled = !Cam1.enabled;

        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Cam2.enabled= !Cam2.enabled;
        }
    }

}
