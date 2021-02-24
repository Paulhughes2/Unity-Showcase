using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{

    public GameObject bullet;
    public Transform firePoint;
    int damage,speed;
    Color col;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
            newBullet.GetComponent<Bullet>().SetStats(damage,speed,col);
        }
    }

    public void Setup(int i,int j,Color c)
    {
        damage = i;
        speed = j;
        col = c;
    }
}
