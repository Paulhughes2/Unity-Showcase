using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BulletShoot : MonoBehaviour
{
    public int maxAmmo, magSize;
    static  int ammoCount,magAmount;
    public GameObject bullet;
    public Transform firePoint;
    int damage, speed;
    Color col;
    public TMP_Text ammoCounter;

    // Start is called before the first frame update
    void Start()
    {
        magAmount = magSize;
        ammoCount = maxAmmo - magAmount;
    }

    // Update is called once per frame
    void Update()
    {
        ammoCounter.text = " " + magAmount + " / " + ammoCount;

        if (Input.GetMouseButtonDown(0))
        {
            if (magAmount > 0)
            {
                GameObject newBullet = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
                newBullet.GetComponent<Bullet>().SetStats(damage, speed, col);
                magAmount--;

            }
            else
            {
                Debug.Log("Mag Empty");
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if(ammoCount >= 0 && magAmount < magSize)
            {
                if(magAmount > 0)
                {
                    ammoCount -= magAmount;
                }
                if(ammoCount >= magSize)
                {
                    magAmount = magSize;
                    ammoCount -= magSize;
                }
                else
                {
                    magAmount = ammoCount;
                    ammoCount -= magAmount;
                }
            }
        }
    }

    public void Setup(int i, int j, Color c)
    {
        damage = i;
        speed = j;
        col = c;
    }
}
