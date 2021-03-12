using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTargets : MonoBehaviour
{

    private static ResetTargets _instance;
    GameObject[] targets;
    Transform[] originalPos;
    public GameObject target;
    bool targetsSet = false;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

            targets = GameObject.FindGameObjectsWithTag("Destroyable");
            originalPos = new Transform[targets.Length];
        if (!targetsSet)
        {
            GetOriginalPos();
        }
    }


    void GetOriginalPos()
    {

        for (int i = 0; i < targets.Length; i++)
        {
            //Debug.Log(g.transform);
            originalPos[i] = targets[i].transform;
            Debug.Log(originalPos[i].transform.position);
        }
        targetsSet = true;
    }
    public void ResetOriginalPos()
    {
        Debug.Log("length: " + targets.Length);
        for (int i = 0; i < targets.Length; i++)
        {
            Debug.Log(originalPos[i].transform.position);

            Instantiate(target, originalPos[i].position, originalPos[i].rotation);

        }
    }
}
