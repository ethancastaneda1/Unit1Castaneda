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
//private variables
//private float speed = 30f;
//pr//ivate float turnSpeed = 45f;
//private float horizontalInput;
//private float forwardInput;


// Start is called before the first frame update
//void Start()
//{

//}

// Update is called once per frame
//void Update()
//{
//  horizontalInput = Input.GetAxis("Horizontal");
//forwardInput = Input.GetAxis("Vertical");

//Move the vehicle forward
//    transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
//  transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
//}
//}
//public float speed = 5.0f;
//public float rotationSpeed = 40f;
//pu/blic float verticalInput;
//public float horizontalInput;

// Start is called before the first frame update
//void Start()
//{

//}

// Update is called once per frame
//void FixedUpdate()
//{
    // get the user's vertical input
  //  verticalInput = Input.GetAxis("Vertical");
    //horizontalInput = Input.GetAxis("Horizontal");
    // move the plane forward at a constant rate
    //transform.Translate(Vector3.forward * speed * Time.deltaTime * horizontalInput);

    // tilt the plane up/down based on up/down arrow keys
//    transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput); 