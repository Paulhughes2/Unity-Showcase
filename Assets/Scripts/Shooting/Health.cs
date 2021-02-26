using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Health : MonoBehaviour
{
    public float hp;
    float currentHP;
    public Material destroyableMat,none_destroyableMat;

    public Slider hpBar;
    public TMP_Text hpText;
    void Awake()
    {
        if(gameObject.tag == "Destroyable")
        {
            //gameObject.GetComponent<Renderer>().material = Resources.Load("Materials/Destroyable.mat", typeof(Material)) as Material;
            gameObject.GetComponent<Renderer>().material = destroyableMat;
            currentHP = hp;
            UpdateUI();
        }
        else
        {
            //gameObject.GetComponent<Renderer>().material = Resources.Load("Materials/None-Destroyable.mat", typeof(Material)) as Material;
            gameObject.GetComponent<Renderer>().material = none_destroyableMat;
            hpBar.gameObject.SetActive(false);
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }

    public void SetHealth(int i)
    {
        hp = i;
    }

    public float GetHealth()
    {
        return currentHP;
    }

    public void TakeDamage(int i)
    {
        currentHP -= i;
        CheckDeath();
    }

    void CheckDeath()
    {
        if (currentHP <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        hpBar.value = (GetHealth()/hp);

        if(hpBar.value >= 0.75)
        {
            hpBar.GetComponentInChildren<Image>().color = Color.green;
        }
        else if (hpBar.value < 0.75 && hpBar.value >= 0.40)
        {
            hpBar.GetComponentInChildren<Image>().color = Color.yellow;
        }
        else if (hpBar.value < 0.40)
        {
            hpBar.GetComponentInChildren<Image>().color = Color.red;
        }
        hpText.text = "HP: " + string.Format("{0:f0}", (hpBar.value *100));
    }
}
