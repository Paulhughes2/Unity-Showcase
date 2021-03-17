using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reticle : MonoBehaviour
{
    public RectTransform crosshair;
    public Camera cam;
    public Transform muzzle;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(muzzle.transform.position, muzzle.transform.forward, out hit))
        {
            if (hit.collider)
            {
                crosshair.position = cam.WorldToScreenPoint(hit.point);
            }
        }
    }
}
