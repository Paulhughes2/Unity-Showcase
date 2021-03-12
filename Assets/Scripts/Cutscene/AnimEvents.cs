using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEvents : MonoBehaviour
{
    public bool finished = false;
    GameObject Player;
    public Camera secondCam;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void finishedAnim()
    {
        finished = true;
        Player.GetComponentInChildren<Camera>().enabled = true;
        secondCam.enabled = false;
    }

    void CameraSwap()
    {
        Player.GetComponentInChildren<Camera>().enabled = false;
        secondCam.enabled = true;
    }
}
