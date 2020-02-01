using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backend : MonoBehaviour
{
    Patient patient;

    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;

    // Start is called before the first frame update
    void Start()
    {
        patient = new Patient();

        MentalDisordersList mentalDisorders = new MentalDisordersList();
        patient.mentalDisorder = mentalDisorders.GetMentalDisorder();

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

        SetupGame();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SetupGame()
    {

    }
}
