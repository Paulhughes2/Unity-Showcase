using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastGun : MonoBehaviour
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

            //The if shoots a ray using the following parameters(our position, our forward direction,a variable for the data to go in,length)
            //The transform.forward may need to be on other axis depending on object rotation, up,right,forward or the - of each. use the debug below to help
            if (Physics.Raycast(transform.position, transform.forward, out hit, 100))
            {
                //This controls what happens to objects with certain tags
                if (hit.transform.tag == "Destroyable")
                {
                    //we just destroy the thing we hit if the tag mataches but you can do other stuff here
                    Destroy(hit.transform.gameObject);

                }
            }
        }
        //The debug draws the ray using the same parameters as above and helps you see which direction the line goes to help line things up
        //Similar Parameters (our position,our forward,a color,length)
        //Debug.DrawRay(transform.position, transform.forward, Color.green, 100);

    }
}
