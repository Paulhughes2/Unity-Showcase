using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerp : MonoBehaviour
{

    public Transform endMarker;
    //Transform startMarker;
    public float speed = 0.1f;
    float startTime, journeyLength;
    bool targetSet = false;
    Vector3 target;
    // Start is called before the first frame update
    void OnEnable()
    {
        startTime = Time.time;

        journeyLength = Vector3.Distance(transform.position, endMarker.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, endMarker.position) > 1.5 )
        {
            if (!targetSet)
            {
            target = endMarker.position;
                targetSet = true;
            }
            //Inverted LookAT
            // transform.LookAt(2 * transform.position - endMarker.position);
            //Normal LookAT
            transform.LookAt(target);

            float distCovered = (Time.time - startTime) * speed;

            float fractOfJourney = distCovered / journeyLength;

            transform.position = Vector3.Lerp(transform.position, target, fractOfJourney);
        }
       if(Vector3.Distance(transform.position,target)<1)
        {
            targetSet = false;
        }
    }
}
