using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletfiring : MonoBehaviour
{
    
    public GameObject bulletmovement;
    public GameObject positionObject;
    Vector3 vel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vel.x = Input.GetAxis("Horizontal");
        vel.z = Input.GetAxis("Vertical");
        if (Input.GetButtonDown("Fire1"))
        {

            GameObject clone = Instantiate(bulletmovement);
            clone.transform.position = positionObject.transform.position;

            //push bullet forward
            clone.GetComponent<Rigidbody>().velocity = new Vector3(3,0,1) ;

        }
    }
}
