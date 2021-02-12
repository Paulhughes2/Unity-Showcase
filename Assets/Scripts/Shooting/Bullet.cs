﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    float spawnTime;
    public float lifeTime;

    // Start is called before the first frame update
    void Start()
    {
        spawnTime = Time.time;
        rb = gameObject.GetComponent<Rigidbody>();

        rb.AddForce(transform.up * speed);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= spawnTime + lifeTime)
        {
            Destroy(gameObject);
        }

    }

    void OnCollisionEnter(Collision collision)
    {
    
        if(collision.gameObject.tag == "Destroyable")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

    }
}