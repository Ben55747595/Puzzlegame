using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject cameraObject;
    public Rigidbody rigidBody;
    public float speed;
    public float maxSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {

            rigidBody.AddForce(transform.forward * speed);
                  
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidBody.AddForce(-transform.forward * speed);

        }

        if (Input.GetKey(KeyCode.A))
        {
            rigidBody.AddForce(-transform.right * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigidBody.AddForce(transform.right * speed);
        }

        if (rigidBody.velocity.magnitude > maxSpeed)
        
        {
            rigidBody.velocity = rigidBody.velocity.normalized * maxSpeed;
        }
        
        if (Input.GetAxis("Mouse X") != 0) 
        {
            Vector3 rotation = new Vector3(0, Input.GetAxis("Mouse X"), 0);
            transform.Rotate(rotation);
        } 

        if(Input.GetAxis("Mouse Y") != 0)
        {
            Vector3 rotation = new Vector3(-Input.GetAxis("Mouse Y"), 0, 0);
            cameraObject.transform.Rotate(rotation);
            // Debug.Log($"Euler x, {cameraObject.transform.rotation.eulerAngles.x}");
            if(cameraObject.transform.rotation.eulerAngles.x < 90)
            {
                cameraObject.transform.rotation = Quaternion.Euler(cameraObject.transform.rotation.eulerAngles.x, 0, 0);               
            } else if(cameraObject.transform.rotation.x < 270)
            {
              //  cameraObject.transform.rotation = Quaternion.Euler(90, 0, 0);
            }          
        }


    }
}
