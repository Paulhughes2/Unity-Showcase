using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStuff : MonoBehaviour
{
    public GameObject enemy;
    float waitTime, currentTime, spawned;
    public float betweenSpawns, spawnAmount;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        if (spawned < spawnAmount)
        {
            currentTime += Time.deltaTime;
            if (currentTime >= waitTime + betweenSpawns)
            {
                Instantiate(enemy, transform.position, transform.rotation);
                waitTime = Time.time;
                spawned++;
            }
        }

        if(spawnAmount >= spawned)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                spawned = 0;
                waitTime = Time.deltaTime;
            }
        }
        Debug.Log(Time.time);
    }
}
