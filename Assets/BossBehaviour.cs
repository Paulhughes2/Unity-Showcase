using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
    public bool randomShooting,shootingPatterns;

    public GameObject firePoint, bullet;
    public int damage, speed;
    public Color col;

    float waitTime, currentTime;
    public float betweenSpawns;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(GameObject.FindGameObjectWithTag("Player").transform, Vector3.up);
        if (randomShooting)
        {
            RandomShooting();
        }
        if (!randomShooting)
        {
            //NormalShooting();
        }

        if (shootingPatterns)
        {
            currentTime = Time.time;
            if (currentTime >= waitTime + betweenSpawns)
            {
                Quaternion temp = firePoint.transform.localRotation;

                fire();
                temp.y = -5f;
                firePoint.transform.rotation = temp;
                fire();


                waitTime = Time.time;
            }
        }

    }

    void fire()
    {
        Debug.Log("Fired");
        GameObject newBullet = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
        newBullet.GetComponent<Bullet>().SetStats(damage, speed, col);
        
    }
    void NormalShooting()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= waitTime + betweenSpawns)
        {
            GameObject newBullet = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
            newBullet.GetComponent<Bullet>().SetStats(damage, speed, col);
            waitTime = Time.time;
        }
    }

    void RandomShooting()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= waitTime + betweenSpawns)
        {
            GameObject newBullet = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
            newBullet.GetComponent<Bullet>().SetStats(damage, speed, col);
            newBullet.transform.localScale *= 2;
            betweenSpawns = Random.Range(0.5f, 2f);
            speed = Random.Range(100, 350);
            waitTime = Time.time;
        }
    }
}
