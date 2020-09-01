using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    float time;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime* 5;

        this.transform.position = new Vector3(Mathf.Sin(time)* 5+ 44.21202f, -17.12f, 4.48f);

    }
}
