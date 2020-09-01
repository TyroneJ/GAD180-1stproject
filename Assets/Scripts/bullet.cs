using Microsoft.Win32;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UIElements;

public class bullet : MonoBehaviour
{
    public int damage = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
  

        DamageScript objectToDamage = collision.gameObject.GetComponent<DamageScript>();
        if (objectToDamage != null)
        {
            objectToDamage.Damage(damage);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag==("bullet"))
        {
            Destroy(this.gameObject);
        }
        
    }

    

    // Update is called once per frame
    void Update()
    {

       
    }

}
