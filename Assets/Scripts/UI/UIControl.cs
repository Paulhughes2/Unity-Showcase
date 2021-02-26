using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour
{
    public void AIButton()
    {
        SceneManager.LoadScene("AI");
    }
    public void LERPButton()
    {
        SceneManager.LoadScene("LERP");
    }
    public void ShootingButton()
    {
        SceneManager.LoadScene("Shooting");
    }
    public void TestingButton()
    {
        SceneManager.LoadScene("Testing");
    }
    public void TimeButton()
    {
        SceneManager.LoadScene("Time");
    }
    public void QuitButton()
    {
        Application.Quit(0);    
    }
}
