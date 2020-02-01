﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backend : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Patient patient = new Patient();
        Debug.Log(patient.name);
        Debug.Log(patient.firstname);

        MentalDisordersList mentalDisorders = new MentalDisordersList();
        patient.mentalDisorder = mentalDisorders.GetMentalDisorder();
        Debug.Log(patient.mentalDisorder.name);

        if(patient.mentalDisorder.name == "Schizophrenia")
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
        } else
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

    // Update is called once per frame
    void Update()
    {

    }
}
