using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Transform crosshair;
    public GameObject pickUpObj;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;

            if (Physics.Raycast(crosshair.position, crosshair.forward,out hit, 100f))
            {

                if(hit.collider.gameObject.tag == "PickUp")
                {
                    GameObject tempGO = hit.collider.gameObject;
                    
                    Debug.Log("Picked up " + tempGO.name);
                    this.gameObject.GetComponent<Inventory>().AddToInventory(tempGO);
                    
                    
                    tempGO.SetActive(false);
                    
                }
            }
        }
    }
}
