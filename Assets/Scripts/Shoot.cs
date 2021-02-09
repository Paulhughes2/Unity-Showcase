using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // IF Space is pressed down
            
            RaycastHit hit;
            //Make a variable to store data on the thing we hit

            if(Physics.Raycast(transform.position,transform.forward,out hit, 100f))
            {
                // IF We fire a raycast from (our position, our forward, output the data into "hit", distance of 100 units) and it hits
                Destroy(hit.transform.gameObject);
                //Destory the thing we hit, accesed by looking at the hit data and finding the gameobject
            }

        }
    }
}
