using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(30, 0, 10);
   
    // Start is called before the first frame update
    void Start()
    {
        //offsetMainCam = transform.position - Plane.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
        // transform.SetPositionAndRotation(Plane.transform.position + offsetMainCam, Quaternion.Euler(camRotation));s
        //transform.position = player.transform.position + offset;
    }
}
