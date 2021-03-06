﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backend : MonoBehaviour
{
    public ObjectList objectLister;
    public Patient patient;



    public GameObject Window;
    public GameObject OpenedWindow;
    public GameObject Radio;
    public GameObject Carpet;
    public GameObject CarpetPlate;
    public GameObject Alcohol;
    public GameObject Cigarette;
    public GameObject Incense;
    public GameObject FamilyPortrait;
    public GameObject CrossedFamilyPortrait;
    public GameObject CallingCard;
    public GameObject WoodToy;
    public GameObject TableauDroit;
    public GameObject Picture;
    public GameObject TerminationLetter;
    public GameObject BlueMedicine;
    public GameObject RedMedicine;
    public GameObject Cookies;
    public GameObject Cube;






    public GameObject PatientSchizo;
    public GameObject PatientADD;
    public GameObject PatientManiac;
    public GameObject PatientToxico;



    public Animator patientAnimator;

    public GameObject loose;
    public GameObject win;
    public GameObject calpin;
    public GameObject gamebutton;







    CalpinScript calpinScript;

    private GameObject obj1;
    private GameObject obj2;
    private GameObject obj3;
    private GameObject obj4;
    private GameObject obj5;

    public GameObject calpinScript01;
    public GameObject calpinScript02;
    public GameObject calpinScript03;
    public GameObject calpinScript04;

    // Start is called before the first frame update
    void Start()
    {
        patient = new Patient();
        objectLister = new ObjectList();

        MentalDisordersList mentalDisorders = new MentalDisordersList(objectLister);
        patient.mentalDisorder = mentalDisorders.GetMentalDisorder();
        Debug.Log(patient.mentalDisorder.name);


        if (patient.mentalDisorder.name == "Schizophrenia")
        {
            foreach (ObjectUsable obj in patient.mentalDisorder.goodObjects)
            {
                obj.setEffet(50);
            }
            foreach (ObjectUsable obj in patient.mentalDisorder.badObjects)
            {
                if (obj.name == "Red medicine")
                {
                    obj.setEffet(50);
                }
                else
                {
                    obj.setEffet(-50);
                }
            }
        }
        else
        {
            foreach (ObjectUsable obj in patient.mentalDisorder.goodObjects)
            {
                obj.setEffet(50);
            }
            foreach (ObjectUsable obj in patient.mentalDisorder.badObjects)
            {
                obj.setEffet(-50);
            }
        }
        ObjectUsable[] objectList = { patient.mentalDisorder.badObjects[0], patient.mentalDisorder.badObjects[1], patient.mentalDisorder.goodObjects[0], patient.mentalDisorder.goodObjects[1], patient.mentalDisorder.neutralObject };

        for (int t = 0; t < objectList.Length; t++)
        {
            ObjectUsable tmp = objectList[t];
            int r = Random.Range(t, objectList.Length);
            objectList[t] = objectList[r];
            objectList[r] = tmp;
        }

        string object01 = objectList[0].usage;
        string object02 = objectList[1].usage;
        string object03 = objectList[2].usage;
        string object04 = objectList[3].usage;
        string object05 = objectList[4].usage;
        string objectEmpty = "";

        calpinScript01.GetComponent<CalpinScript>().SetCalpin(patient.name, patient.firstname, object01, object02, object03);
        calpinScript02.GetComponent<CalpinScript>().SetCalpin(patient.name, patient.firstname, object04, object05, objectEmpty);
        calpinScript03.GetComponent<CalpinScript>().SetCalpin(patient.name, patient.firstname, objectEmpty, objectEmpty, objectEmpty);
        calpinScript04.GetComponent<CalpinScript>().SetCalpin(patient.name, patient.firstname, objectEmpty, objectEmpty, objectEmpty);

        SetupScene();
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("Plus : " + patient.ClientMindHealthPlus);
        Debug.Log("Min : " + patient.ClientMindHealthMin);


        if (patient.ClientMindHealthMin == -100)
        {
            win.SetActive(false);
            loose.SetActive(true);
            calpin.SetActive(false);
            gamebutton.SetActive(false);
        }
        if (patient.ClientMindHealthPlus == 100)
        {
            win.SetActive(true);
            loose.SetActive(false);
            calpin.SetActive(false);
            gamebutton.SetActive(false);
        }
    }

    public void NewPatient()
    {
        patient = null;
        patient = new Patient();

        MentalDisordersList mentalDisorders = new MentalDisordersList(objectLister);
        patient.mentalDisorder = mentalDisorders.GetMentalDisorder();

        if (patient.mentalDisorder.name == "Schizophrenia")
        {
            foreach (ObjectUsable obj in patient.mentalDisorder.goodObjects)
            {
                obj.setEffet(50);
            }
            foreach (ObjectUsable obj in patient.mentalDisorder.badObjects)
            {
                if (obj.name == "Red medicine")
                {
                    obj.setEffet(50);
                }
                else
                {
                    obj.setEffet(-50);
                }
            }
        }
        else
        {
            foreach (ObjectUsable obj in patient.mentalDisorder.goodObjects)
            {
                obj.setEffet(50);
            }
            foreach (ObjectUsable obj in patient.mentalDisorder.badObjects)
            {
                obj.setEffet(-50);
            }
        }



        ObjectUsable[] objectList = { patient.mentalDisorder.badObjects[0], patient.mentalDisorder.badObjects[1], patient.mentalDisorder.goodObjects[0], patient.mentalDisorder.goodObjects[1], patient.mentalDisorder.neutralObject };

        for (int t = 0; t < objectList.Length; t++)
        {
            ObjectUsable tmp = objectList[t];
            int r = Random.Range(t, objectList.Length);
            objectList[t] = objectList[r];
            objectList[r] = tmp;
        }

        string object01 = objectList[0].usage;
        string object02 = objectList[1].usage;
        string object03 = objectList[2].usage;
        string object04 = objectList[3].usage;
        string object05 = objectList[4].usage;
        string objectEmpty = "";

        calpinScript01.GetComponent<CalpinScript>().SetCalpin(patient.name, patient.firstname, object01, object02, object03);
        calpinScript02.GetComponent<CalpinScript>().SetCalpin(patient.name, patient.firstname, object04, object05, objectEmpty);
        calpinScript03.GetComponent<CalpinScript>().SetCalpin(patient.name, patient.firstname, objectEmpty, objectEmpty, objectEmpty);
        calpinScript04.GetComponent<CalpinScript>().SetCalpin(patient.name, patient.firstname, objectEmpty, objectEmpty, objectEmpty);

        SetupScene();
    }

    void SetupScene()
    {

        Window.SetActive(true);
        OpenedWindow.SetActive(false);
        Carpet.SetActive(false);
        CarpetPlate.SetActive(true);
        Incense.SetActive(false);
        FamilyPortrait.SetActive(true);
        CrossedFamilyPortrait.SetActive(false);
        CallingCard.SetActive(false);
        TableauDroit.SetActive(true);
        Picture.SetActive(false);
        TerminationLetter.SetActive(false);
        BlueMedicine.SetActive(false);
        RedMedicine.SetActive(false);
        Cookies.SetActive(false);
        Cube.SetActive(false);

        DisplayCorrect();
        DisplayPatient(patient.mentalDisorder.name);
    }

    void DisplayCorrect()
    {
        switch (patient.mentalDisorder.name)
        {
            case "Schizophrenia":
                CrossedFamilyPortrait.SetActive(true);
                FamilyPortrait.SetActive(false);
                BlueMedicine.SetActive(true);
                RedMedicine.SetActive(true);
                CallingCard.SetActive(true);
                break;
            case "Attention deficit disorder":
                Cookies.SetActive(true);
                break;
            case "Drug Addiction":
                TerminationLetter.SetActive(true);
                break;
            case "Maniac":
                Incense.SetActive(true);
                Carpet.SetActive(true);
                CarpetPlate.SetActive(false);
                Picture.SetActive(true);
                TableauDroit.SetActive(false);
                Cube.SetActive(true);
                break;
            case null:
                break;
        }
    }

    public void changeState(string name)
    {
        switch (name)
        {
            case "Incense":
                Debug.Log("START ANIMATION encens");
                break;
            case "Rubik's Cube":
                Debug.Log("START ANIMATION rubiks resolve");
                break;
            case "Picture":
                Picture.SetActive(false);
                TableauDroit.SetActive(true);
                break;
            case "Carpet":
                Carpet.SetActive(false);
                CarpetPlate.SetActive(true);
                break;
            case "Family Portrait":
                break;
            case "Termination Letter":
                break;
            case "Alcohol":
                Debug.Log("Change sprite Bottle empty");
                break;
            case "Cigarette":
                break;
            case "Cookies":
                break;
            case "Radio":
                Debug.Log("Activate/desactivate music");

                break;
            case "Wood toy":
                break;
            case "Window":
                Window.SetActive(false);
                OpenedWindow.SetActive(true);
                break;
            case "Blue medicine":
                BlueMedicine.SetActive(false);
                break;
            case "Red medicine":
                RedMedicine.SetActive(false);
                break;
            case "Crossed family portrait":
                break;
            case "Calling card":
                CallingCard.SetActive(false);
                break;
            case null:
                break;
        }
    }

    public void DisplayPatient(string mDisorder)
    {
        switch (mDisorder)
        {
            case "Schizophrenia":
                PatientSchizo.SetActive(true);
                PatientADD.SetActive(false);
                PatientToxico.SetActive(false);
                PatientManiac.SetActive(false);


                patientAnimator = PatientSchizo.GetComponent<Animator>();
                break;
            case "Attention deficit disorder":
                PatientSchizo.SetActive(false);
                PatientADD.SetActive(true);
                PatientToxico.SetActive(false);
                PatientManiac.SetActive(false);
                patientAnimator = PatientADD.GetComponent<Animator>();
                break;
            case "Drug Addiction":
                PatientSchizo.SetActive(false);
                PatientADD.SetActive(false);
                PatientToxico.SetActive(true);
                PatientManiac.SetActive(false);
                patientAnimator = PatientToxico.GetComponent<Animator>();
                break;
            case "Maniac":
                PatientSchizo.SetActive(false);
                PatientADD.SetActive(false);
                PatientToxico.SetActive(false);
                PatientManiac.SetActive(true);
                patientAnimator = PatientManiac.GetComponent<Animator>();

                break;
            case null:
                break;
        }
    }
}
