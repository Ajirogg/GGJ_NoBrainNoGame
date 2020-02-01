using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CalpinScript : MonoBehaviour
{

    [SerializeField]
    public Text prenomNomText;
    public Text line01;
    public Text line02;
    public Text line03;
    public GameObject Page01;
    public GameObject Page02;
    public GameObject Page03;
    public GameObject Page04;
    public bool isCalpinActive = false;


    void Start()
    {

    }

    public void SetCalpin(string actualname, string actualFirstname, string actualLine01, string actualLine02, string actualLine03)
    {
        prenomNomText.text = actualname + " " + actualFirstname;
        if (this.name == "CanvasCalpin01")
        {
            line01.text = "• " + actualLine01;
            line02.text = "• " + actualLine02;
            line03.text = "• " + actualLine03;
        }
        else if (this.name == "CanvasCalpin02")
        {
            line01.text = "• " + actualLine01;
            line02.text = "• " + actualLine02;
            line03.text = "";
        }
        else
        {
            line01.text = "";
            line02.text = "";
            line03.text = "";
        }
        Page01.SetActive(true);
        Page02.SetActive(false);
        Page03.SetActive(false);
        Page04.SetActive(false);
    }

    public void PreviousPage()
    {
        if (Page01.active == true)
        {

        }
        else if (Page02.active == true)
        {
            Page01.SetActive(true);
            Page02.SetActive(false);
            Page03.SetActive(false);
            Page04.SetActive(false);
        }
        else if (Page03.active == true)
        {
            Page01.SetActive(false);
            Page02.SetActive(true);
            Page03.SetActive(false);
            Page04.SetActive(false);
        }
        else if (Page04.active == true)
        {
            Page01.SetActive(false);
            Page02.SetActive(false);
            Page03.SetActive(true);
            Page04.SetActive(false);
        }
    }

    public void NextPage()
    {
        if (Page01.active == true)
        {
            Page01.SetActive(false);
            Page02.SetActive(true);
            Page03.SetActive(false);
            Page04.SetActive(false);
        }
        else if (Page02.active == true)
        {
            Page01.SetActive(false);
            Page02.SetActive(false);
            Page03.SetActive(true);
            Page04.SetActive(false);
        }
        else if (Page03.active == true)
        {
            Page01.SetActive(false);
            Page02.SetActive(false);
            Page03.SetActive(false);
            Page04.SetActive(true);
        }
        else if (Page04.active == true)
        {

        }
    }

    public void ShowHideCalpin()
    {
        isCalpinActive = !isCalpinActive;

        if (isCalpinActive)
        {
            // Do transfome here
        }
        else if (!isCalpinActive)
        {
            // Do transfome here
            Page01.SetActive(true);
            Page02.SetActive(false);
            Page03.SetActive(false);
            Page04.SetActive(false);
        }
    }
}
