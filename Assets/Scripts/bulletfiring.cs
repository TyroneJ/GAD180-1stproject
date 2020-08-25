using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletfiring : MonoBehaviour
{
    
    public GameObject bulletmovement;
    public GameObject positionObject;
    Vector3 vel;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vel.x = Input.GetAxis("Horizontal");
        vel.z = Input.GetAxis("Vertical");
        if (Input.GetButtonDown("Space"))
        {
            RandomShooting();

            //push bullet forward

            bulletmovement.GetComponent<Rigidbody>().velocity = new Vector3(3,0,1) ;

        }
    }

    public void RandomShooting()
    {

        GameObject obj = Instantiate(bulletmovement);
        obj.transform.position = this.transform.position;

        float rx = Random.Range(-0.5f, 0.5f);
        float ry = 0;
        float rz = this.transform.forward.z;

        Vector3 direction = new Vector3(rx, ry, rz);

        direction.Normalize();

        obj.GetComponent<Rigidbody>().velocity = direction*speed;

      

    }


}
