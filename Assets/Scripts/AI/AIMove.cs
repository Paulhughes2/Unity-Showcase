using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMove : MonoBehaviour
{

    public Transform target;
    Vector3 leashOrigin;
    public float range, leashRange;
    public float attackRange;
    NavMeshAgent agent;
    bool originSet = false;
    bool hasLOS;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        leashOrigin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            if (Vector3.Distance(transform.position, target.position) <= range && losCheck())
            {
                if (!originSet)
                {
                    leashOrigin = transform.position;
                    originSet = true;
                }

                if (Vector3.Distance(transform.position, target.position) > attackRange)
                {
                    agent.isStopped = false;
                    agent.SetDestination(target.position);
                }
                else
                {
                    agent.isStopped = true;
                }

                if (agent.isStopped == true)
                {

                    if (losCheck())
                    {
                        RaycastHit hit;

                        if (Physics.Raycast(transform.position, transform.forward, out hit, 100))
                        {
                            if (hit.transform.tag == "Player")
                            {

                                Destroy(hit.transform.gameObject);

                            }
                        }
                    }
                }
            }
            else if (Vector3.Distance(transform.position, leashOrigin) > leashRange && agent.destination != target.position)
            {
                agent.SetDestination(leashOrigin);
            }
            else
            {
                agent.isStopped = false;
                if (Vector3.Distance(transform.position, target.position) < .5)
                {
                    agent.SetDestination(leashOrigin);
                }
                else if (Vector3.Distance(transform.position, leashOrigin) < .5)
                {
                    agent.SetDestination(target.position);

                }
            }
        }
        //Debug.DrawRay(transform.position, transform.forward, Color.green, 100);
    }


    bool losCheck()
    {
        transform.LookAt(target.position, transform.up);

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 100))
        {
            if (hit.transform.gameObject.tag == "Player")
            {
                hasLOS = true;
            }
        }
        else
        {
            hasLOS = false;
        }
        return hasLOS;
    }
}
