using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject enemy;
    float waitTime, currentTime, spawned;
    public float betweenSpawns, spawnAmount;
    Vector3 randomSpawnPos;

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
                RandomiseSpawn();
                Instantiate(enemy, randomSpawnPos, transform.rotation);
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
       
    }

    void RandomiseSpawn()
    {
        randomSpawnPos = transform.position;

        int i = Random.Range(-5,6);
        int j = Random.Range(-5,6);

        randomSpawnPos.x += i;
        randomSpawnPos.z += j;
    }

}
