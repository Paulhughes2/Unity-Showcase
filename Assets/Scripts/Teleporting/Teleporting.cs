using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporting : MonoBehaviour
{

    public GameObject sphere, cube, cylinder;
    Vector3 offSet;

    // Start is called before the first frame update
    void Start()
    {
        SetOffset();
        cylinder.transform.position = gameObject.transform.position + offSet;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SetOffset();
            cube.transform.position = transform.position + offSet;
        }
    }
    void SetOffset()
    {
        offSet = new Vector3(Random.Range(-1, -2), 0, Random.Range(-1, -2));
    }
}
