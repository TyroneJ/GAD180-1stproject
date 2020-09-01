using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{

    public int hp;

    public void Damage(int damage)
    {
        hp -= damage;

        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
