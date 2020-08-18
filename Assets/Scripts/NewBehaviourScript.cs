using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool up = false;
    public bool down = false;
    public bool left = false;
    public bool right = false;
    public bool jump = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        up = down = left = right = jump = false;

        if(Input.GetKey(KeyCode.W))
        {
            up = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            left = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            down = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            right = true;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
       
            GetComponent<Rigidbody>().velocity = new Vector3();
        
        if (left)
        {
            GetComponent<Rigidbody>().velocity += new Vector3(-10, 0, 0);

        }
        if (right)
        {
            GetComponent<Rigidbody>().velocity += new Vector3(10, 0, 0);

        }
        if (up)
        {
            GetComponent<Rigidbody>().velocity += new Vector3(0, 0, 10);

        }
        if (down)
        {
            GetComponent<Rigidbody>().velocity += new Vector3(0, 0, -10);

        }
        if (jump)
        {
            GetComponent<Rigidbody>().velocity += new Vector3(0, 10, 0);

        }
    }

}
