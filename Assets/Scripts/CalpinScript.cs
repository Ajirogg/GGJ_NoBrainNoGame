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

    PatientInfo patient;


    void Start()
    {
        patient = GetComponent<PatientInfo>();
        //prenomNomText.text = patient.actualname + " " + patient.actualFirstname;
        line01.text = "";
        line02.text = "";
        line03.text = "";
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
            line01.text = "";
            line03.text = "";
            line03.text = "";
        }
        else if (Page03.active == true)
        {
            Page01.SetActive(false);
            Page02.SetActive(true);
            Page03.SetActive(false);
            Page04.SetActive(false);
            line01.text = "";
            line03.text = "";
            line03.text = "";
        }
        else if (Page04.active == true)
        {
            Page01.SetActive(false);
            Page02.SetActive(false);
            Page03.SetActive(true);
            Page04.SetActive(false);
            line01.text = "";
            line03.text = "";
            line03.text = "";
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
            line01.text = "";
            line03.text = "";
            line03.text = "";
        }
        else if (Page02.active == true)
        {
            Page01.SetActive(false);
            Page02.SetActive(false);
            Page03.SetActive(true);
            Page04.SetActive(false);
            line01.text = "";
            line03.text = "";
            line03.text = "";
        }
        else if (Page03.active == true)
        {
            Page01.SetActive(false);
            Page02.SetActive(false);
            Page03.SetActive(false);
            Page04.SetActive(true);
            line01.text = "";
            line03.text = "";
            line03.text = "";
        }
        else if (Page04.active == true)
        {

        }
    }

    public void ShowHideCalpin()
    {

    }
}
