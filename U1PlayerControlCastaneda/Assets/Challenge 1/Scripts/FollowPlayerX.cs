using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offsetMainCam = new Vector3(20,0,0);
    private Vector3 camRotation = new Vector3(0,-90,0);
    // Start is called before the first frame update
    void Start()
    {
        //offsetMainCam = transform.position - Plane.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // transform.SetPositionAndRotation(Plane.transform.position + offsetMainCam, Quaternion.Euler(camRotation));
        //transform.position = player.transform.position + offset;
    }
}
