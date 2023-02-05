using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class HUDController : MonoBehaviour
{
    public GameObject HUD;
    public GameObject endLevel;
    public Image imag;
    void Update()
    {
        float a= (float)PlayerManager.instantiate.vida / (float)PlayerManager.instantiate.MaxVida;
        imag.fillAmount = (float)PlayerManager.instantiate.vida / (float)PlayerManager.instantiate.MaxVida;
        
        if (PlayerManager.instantiate.isDead)
        {
            if (!endLevel.active)
            {
                Time.timeScale = 0;
                endLevel.SetActive(true);
                HUD.SetActive(false);
            }
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
