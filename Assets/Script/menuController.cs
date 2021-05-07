using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour
{
    public GameObject optionsPanel;
    public GameObject optionsPanel2;

    public void OptionsPanel()
    {
        Time.timeScale = 0;
        optionsPanel.SetActive(true);
    }
    public void OptionsConfg()
    {
        Time.timeScale = 0;
        //optionsPanel.SetActive(false);
        optionsPanel2.SetActive(true);
    }

    public void Return()
    {
        Time.timeScale = 1;
        optionsPanel.SetActive(false);
        //optionsPanel2.SetActive(false);
    }
    public void ExitGame()
    {
        //Application.Quit();
        Time.timeScale = 1;
        SceneManager.LoadScene(0);

    }
}
