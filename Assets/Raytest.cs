using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleMan.VisualRaycast;

public class Raytest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CastResult result = this.Raycast(transform.position, transform.forward);
        if (result)
        {
            if (result.FirstHit.transform.gameObject.tag == "Reflection")
            {
                Vector3 reflectposition = Vector3.Reflect(transform.forward, result.FirstHit.normal);



                this.Raycast(result.FirstHit.point, reflectposition);
            }
        }
    }
}
