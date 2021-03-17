using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{

    public List<GameObject> inventoryList = new List<GameObject>();
    public GameObject inventScreen;
    bool isShowing;
    public Image[] inventImages;

    // Start is called before the first frame update
    void Start()
    {
       inventImages = inventScreen.GetComponentsInChildren<Image>();
        ResetUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            isShowing = !isShowing;
            inventScreen.SetActive(isShowing);
        }

    }

    public void AddToInventory(GameObject g)
    {
        if (!inventoryList.Contains(g))
        {
            inventoryList.Add(g);
            setUION(g);
        }
    }
    public void RemoveToInventory(GameObject g)
    {
        if (inventoryList.Contains(g))
        {
            inventoryList.Remove(g);
        }
    }
    void ResetUI()
    {
        for (int i = 0; i < inventImages.Length; i++)
        {
            inventImages[i].gameObject.SetActive(false);
        }
    }
    void setUION(GameObject g)
    {
        for(int i = 0; i < inventImages.Length; i++)
        {Debug.Log("here");
            if(inventImages[i].gameObject.name == g.name)
            {
                
                inventImages[i].gameObject.SetActive(true);
              
            }
        }
    }
}
