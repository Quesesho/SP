using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject VolumePanel;
    public GameObject CreditsPanel;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void PlayBtn()
    {
        SceneManager.LoadScene(1);
    }
    public void GoToVolumen()
    {
        mainPanel.SetActive(false);
        VolumePanel.SetActive(true);
    }
    public void GoToMain()
    {
        mainPanel.SetActive(true);
        VolumePanel.SetActive(false);
        CreditsPanel.SetActive(false);
    }
    public void CloseGame()
    {
        Application.Quit();
    }
    public void GoToCredits()
    {
        mainPanel.SetActive(false);
        CreditsPanel.SetActive(true);
    }
}
