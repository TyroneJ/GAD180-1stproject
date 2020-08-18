using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deflecting : MonoBehaviour
{
    public Vector3 deflectingVector = Vector3.one;
    public bool player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Vector3 velocity = other.GetComponent<Rigidbody>().velocity;

        velocity.z = deflectingVector.z* velocity.z;
        velocity.x = deflectingVector.x* velocity.x;
        velocity.y = deflectingVector.y * velocity.y;
        if (player)
        {
            velocity += this.GetComponent<Rigidbody>().velocity*.2f;
        }

        other.GetComponent<Rigidbody>().velocity = velocity;

    }
}
