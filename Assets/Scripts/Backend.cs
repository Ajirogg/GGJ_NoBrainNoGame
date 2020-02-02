using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backend : MonoBehaviour
{
    public ObjectList objectLister;
    public Patient patient;


    CalpinScript calpinScript;

    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;

    public GameObject calpinScript01;
    public GameObject calpinScript02;
    public GameObject calpinScript03;
    public GameObject calpinScript04;


    public GameObject win;
    public GameObject loose;
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
        ObjectUsable[] objectList = {patient.mentalDisorder.badObjects[0], patient.mentalDisorder.badObjects[1], patient.mentalDisorder.goodObjects[0], patient.mentalDisorder.goodObjects[1], patient.mentalDisorder.neutralObject};

        for (int t = 0; t < objectList.Length; t++)
        {
            ObjectUsable tmp = objectList[t];
            int r = Random.Range(t, objectList.Length);
            objectList[t] = objectList[r];
            objectList[r] = tmp;
        }

     /*     string object01 = objectList[0].usage;
        string object02 = objectList[1].usage;
        string object03 = objectList[2].usage;
        string object04 = objectList[3].usage;
        string object05 = objectList[4].usage;
        string objectEmpty = "";

      calpinScript01.GetComponent<CalpinScript>().SetCalpin(patient.name, patient.firstname, object01, object02, object03);
        calpinScript02.GetComponent<CalpinScript>().SetCalpin(patient.name, patient.firstname, object04, object05, objectEmpty);
        calpinScript03.GetComponent<CalpinScript>().SetCalpin(patient.name, patient.firstname, objectEmpty, objectEmpty, objectEmpty);
        calpinScript04.GetComponent<CalpinScript>().SetCalpin(patient.name, patient.firstname, objectEmpty, objectEmpty, objectEmpty);
        */
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Mauvais = " + patient.ClientMindHealthMin);
        Debug.Log("Bon = " + patient.ClientMindHealthPlus);
        loose.SetActive(false);
        win.SetActive(false);
        if (patient.ClientMindHealthMin == -100){
            
            Debug.Log(patient.name + " " + patient.firstname + " " + patient.mentalDisorder.name);
            loose.SetActive(true);

        }
        if (patient.ClientMindHealthPlus == 100){
            
            Debug.Log(patient.name + " " + patient.firstname + " " + patient.mentalDisorder.name);
            win.SetActive(true);
        }



    }

    public void NewPatient(){
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
    }

}
