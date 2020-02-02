using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject credits;

    void Start()
    {
        mainMenu.SetActive(true);
        credits.SetActive(false);
    }

    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
          Application.Quit();
#endif
    }

    public void DisplayCredits()
    {
        mainMenu.SetActive(false);
        credits.SetActive(true);
    }

    public void HideCredits()
    {
        mainMenu.SetActive(true);
        credits.SetActive(false);
    }
}
