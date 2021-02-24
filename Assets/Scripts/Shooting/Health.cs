using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int hp;
    public Material destroyableMat,none_destroyableMat;
    void Awake()
    {
        if(gameObject.tag == "Destroyable")
        {
            //gameObject.GetComponent<Renderer>().material = Resources.Load("Materials/Destroyable.mat", typeof(Material)) as Material;
            gameObject.GetComponent<Renderer>().material = destroyableMat;
        }
        else
        {
            //gameObject.GetComponent<Renderer>().material = Resources.Load("Materials/None-Destroyable.mat", typeof(Material)) as Material;
            gameObject.GetComponent<Renderer>().material = none_destroyableMat;
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }

    public void SetHealth(int i)
    {
        hp = i;
    }

    public int GetHealth()
    {
        return hp;
    }

    public void TakeDamage(int i)
    {
        hp -= i;
        CheckDeath();
    }

    void CheckDeath()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
