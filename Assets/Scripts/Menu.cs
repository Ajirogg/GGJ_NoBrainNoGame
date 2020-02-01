using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public Sprite btnStandard;
    public Sprite btnOver;
    public Sprite btnClick;

    public Canvas mainMenu;
    public Canvas credits;
    // Start is called before the first frame update
    void Start()
    {
        credits.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnterOverBtn()
    {
        Image btn = gameObject.GetComponent<Image>();
        btn.sprite = btnOver;
    }

    public void ExitOverBtn()
    {
        Image btn = gameObject.GetComponent<Image>();
        btn.sprite = btnStandard;
    }

    public void BtnClick()
    {
        Image btn = gameObject.GetComponent<Image>();
        btn.sprite = btnClick;
    }

    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void DisplayCredits()
    {
        mainMenu.enabled = false;
        credits.enabled = true;
    }

    public void HideCredits()
    {
        mainMenu.enabled = true;
        credits.enabled = false;
    }
}
