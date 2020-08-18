using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updated : MonoBehaviour
{
    //section 1 defining variables that'll be used/accessed across the entire code

    float x;

    public Vector3 velocity;
    private bool jump;
    public float speed;
    public float jumpspeed;

    void Start()
    {

        //section 2

    }

    Vector3 temp;
    void Update()
    {
        //velocity.z = Input.GetAxis("Vertical")*speed;
        velocity.x = Input.GetAxis("Horizontal")*speed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

       
    }

    private void FixedUpdate()
    {

        //section 4 used to deal with physics and only to do with physics
        //if your line doesnt have GetComponent <RigidBody> then it doesnt belong in here
        velocity.y = GetComponent<Rigidbody>().velocity.y;
       
        //if (jump)
        //{
        //    velocity.y = jumpspeed;
        //    jump = false;
        //}
        GetComponent<Rigidbody>().velocity = velocity;
    }
}
