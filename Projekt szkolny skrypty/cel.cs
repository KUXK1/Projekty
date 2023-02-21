using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cel : MonoBehaviour
{
    public float hp = 100f;
    public void takedmg(float amount)
    {
        hp -= amount;
        if(hp <=0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
