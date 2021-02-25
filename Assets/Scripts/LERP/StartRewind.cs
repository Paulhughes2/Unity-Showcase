using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRewind : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            gameObject.GetComponent<Rewind>().enabled = true;
        }
    }
}
