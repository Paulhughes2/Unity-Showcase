﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.up, out hit, 100))
            {
                if (hit.transform.tag == "Destroyable")
                {

                    Destroy(hit.transform.gameObject);

                }
            }
        }

        //Debug.DrawRay(transform.position, transform.up, Color.green, 100);

    }
}
