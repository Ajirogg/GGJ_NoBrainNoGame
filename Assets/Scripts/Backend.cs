using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backend : MonoBehaviour
{
    public Patient patient;
    CalpinScript calpinScript;

    ObjectList objList = new ObjectList();

    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;



    public GameObject calpinScript01;
    public GameObject calpinScript02;
    public GameObject calpinScript03;
    public GameObject calpinScript04;

    // Start is called before the first frame update
    void Start()
    {
        patient = new Patient();

        MentalDisordersList mentalDisorders = new MentalDisordersList();
        patient.mentalDisorder = mentalDisorders.GetMentalDisorder();
        Debug.Log(patient.mentalDisorder.name);

        NewPatient();
        
        ObjectUsable[] objectList = {patient.mentalDisorder.badObjects[0], patient.mentalDisorder.badObjects[1], patient.mentalDisorder.goodObjects[0], patient.mentalDisorder.goodObjects[1], patient.mentalDisorder.neutralObject};

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


        if(patient.mentalDisorder.name == "Maniac"){
            foreach(ObjectUsable obj in patient.ObjectLister.neutralManiac){
                GameObject.FindGameObjectWithTag(obj.name).SetActive(true);
            }
        }
        if(patient.mentalDisorder.name == "Drug Addiction"){
            foreach(ObjectUsable obj in patient.ObjectLister.neutralAddict){
                GameObject.FindGameObjectWithTag(obj.name).SetActive(true);
            }
        }
        if(patient.mentalDisorder.name == "Attention deficit disorder"){
            foreach(ObjectUsable obj in patient.ObjectLister.neutralADD){
                GameObject.FindGameObjectWithTag(obj.name).SetActive(true);
            }
        }
        if(patient.mentalDisorder.name == "Schizophrenia"){
            foreach(ObjectUsable obj in patient.ObjectLister.neutralSchizo){
                GameObject.FindGameObjectWithTag(obj.name).SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(patient.ClientMindHealthMin);
        Debug.Log(patient.ClientMindHealthPlus);

        

        if (patient.ClientMindHealthMin == -100){
            NewPatient();
            
        }
        if(patient.ClientMindHealthPlus == 100){
            NewPatient();
        }
        


    }

    void NewPatient(){

        patient = new Patient();
        

        MentalDisordersList mentalDisorders = new MentalDisordersList();
        patient.mentalDisorder = mentalDisorders.GetMentalDisorder();

        
        
        foreach (ObjectUsable item in patient.ObjectLister.objects)
        {
            
            GameObject objact = GameObject.FindGameObjectWithTag(item.name);
            Debug.Log(objact);
            //objact.SetActive(false);
        }

        if (patient.mentalDisorder.name == "Schizophrenia")
        {
            foreach (ObjectUsable obj in patient.mentalDisorder.goodObjects)
            {
                obj.setEffet(50);
                GameObject.FindGameObjectWithTag(obj.name).SetActive(true);
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
                GameObject.FindGameObjectWithTag(obj.name).SetActive(true);
            }
            foreach (ObjectUsable obj in patient.mentalDisorder.badObjects)
            {
                obj.setEffet(-50);
                GameObject.FindGameObjectWithTag(obj.name).SetActive(true);
            }
        }
        if(patient.mentalDisorder.name == "Maniac"){
            foreach(ObjectUsable obj in patient.ObjectLister.neutralManiac){
                GameObject.FindGameObjectWithTag(obj.name).SetActive(true);
            }
        }
        if(patient.mentalDisorder.name == "Drug Addiction"){
            foreach(ObjectUsable obj in patient.ObjectLister.neutralAddict){
                GameObject.FindGameObjectWithTag(obj.name).SetActive(true);
            }
        }
        if(patient.mentalDisorder.name == "Attention deficit disorder"){
            foreach(ObjectUsable obj in patient.ObjectLister.neutralADD){
                GameObject.FindGameObjectWithTag(obj.name).SetActive(true);
            }
        }
        if(patient.mentalDisorder.name == "Schizophrenia"){
            foreach(ObjectUsable obj in patient.ObjectLister.neutralSchizo){
                GameObject.FindGameObjectWithTag(obj.name).SetActive(true);
            }
        }
    
    }

}
