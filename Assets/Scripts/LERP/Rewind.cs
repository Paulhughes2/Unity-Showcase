using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rewind : MonoBehaviour
{

    public Transform endMarker;
    //Transform startMarker;
    public float speed = 1;
    float startTime, journeyLength;

    // Start is called before the first frame update
    void OnEnable()
    {
        startTime = Time.time;

        journeyLength = Vector3.Distance(transform.position, endMarker.position);
    }

    // Update is called once per frame
    void Update()
    { 
        //Inverted LookAT
        // transform.LookAt(2 * transform.position - endMarker.position);
        //Normal LookAT
        transform.LookAt(endMarker.position);

        float distCovered = (Time.time - startTime) * speed;

        float fractOfJourney = distCovered / journeyLength;

        transform.position = Vector3.Lerp(transform.position, endMarker.position, fractOfJourney);

        if(Vector3.Distance(transform.position, endMarker.position) < 1)
        {
            this.enabled = false;
        }

    }
}
