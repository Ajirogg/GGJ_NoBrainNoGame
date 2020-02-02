using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalpinScript : MonoBehaviour
{
    [SerializeField] private Text prenomNomText = null;
    [SerializeField] private Text line01 = null;
    [SerializeField] private Text line02 = null;
    [SerializeField] private Text line03 = null;
    [SerializeField] private GameObject Page01 = null;
    [SerializeField] private GameObject Page02 = null;
    [SerializeField] private GameObject Page03 = null;
    [SerializeField] private GameObject Page04 = null;


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

    public void EventCalpin(string eventToAdd)
    {
        if (this.name == "CanvasCalpin03" && line01.text == "")
        {
            line01.text = "• " + eventToAdd;
        }
        else if (this.name == "CanvasCalpin03" && line02.text == "")
        {
            line02.text = "• " + eventToAdd;
        }
        else if (this.name == "CanvasCalpin03" && line03.text == "")
        {
            line03.text = "• " + eventToAdd;
        }
        else if (this.name == "CanvasCalpin04" && line01.text == "")
        {
            line01.text = "• " + eventToAdd;
        }
        else if (this.name == "CanvasCalpin04" && line02.text == "")
        {
            line02.text = "• " + eventToAdd;
        }
    }
}
