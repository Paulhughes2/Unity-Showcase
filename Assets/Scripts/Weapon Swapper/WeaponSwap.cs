using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwap : MonoBehaviour
{
    GameObject gun;
    int currentWeapon,selectedWeapon,damage,bulletSpeed;
    Color col;

    // Start is called before the first frame update
    void Start()
    {
        gun = GameObject.FindGameObjectWithTag("PlayerGun");
        selectedWeapon = 1;
        currentWeapon = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            selectedWeapon = 1;
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            selectedWeapon = 2;
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            selectedWeapon = 3;
        }
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            selectedWeapon = 4;
        }

        if (selectedWeapon != currentWeapon && selectedWeapon != 0 )
        {
            gun.SetActive(true);
            switch (selectedWeapon)
            {
                case 1:
                    damage = 1;
                    bulletSpeed = 1000;
                    col = Color.green;
                    break;
                case 2:
                    damage = 2;
                    bulletSpeed = 700;
                    col = Color.blue;
                    break;
                case 3:
                    damage = 3;
                    bulletSpeed = 500;
                    col = Color.red;
                    break;
                case 4:
                    bulletSpeed = 1500;
                    damage = 0;
                    col = Color.white;
                    break;
                default:
                    bulletSpeed = 1000;
                    damage = 1;
                    col = Color.green;
                    break;

            }
            currentWeapon = selectedWeapon;
            selectedWeapon = 0;
            WeaponSetup();
        }
        else if(currentWeapon == selectedWeapon)
        {
            currentWeapon = 0;
            selectedWeapon = 0;
            gun.SetActive(false);
        }
    }

    void WeaponSetup()
    {
        gun.GetComponent<BulletShoot>().Setup(damage,bulletSpeed,col);
        gun.GetComponent<Renderer>().material.color = col;
    }
}
