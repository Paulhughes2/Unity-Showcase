using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutscenePlayer : MonoBehaviour
{
    public Animator anim;
    GameObject tempGO;
    float tempWalk, tempRun, tempJump;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            tempGO = other.gameObject;
            GetDefaults(tempGO);
            anim.Play("Cutscene1");
        
        }
    }
    private void Update()
    {
        if(anim.gameObject.GetComponent<AnimEvents>().finished == true)
        {
            Enable(tempGO);
        }
    }


    void GetDefaults(GameObject g)
    {
        tempWalk = g.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_WalkSpeed;
        tempRun = g.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_RunSpeed;
        tempJump = g.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_JumpSpeed;
        Disable(g);
    }

    void Disable(GameObject g)
    {
        g.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_WalkSpeed = 0;
        g.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_RunSpeed = 0;
        g.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_JumpSpeed = 0;
    }

    void Enable(GameObject g)
    {
        g.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_WalkSpeed = tempWalk;
        g.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_RunSpeed = tempRun;
        g.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_JumpSpeed = tempJump;
    }
}
