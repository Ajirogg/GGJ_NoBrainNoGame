using System.Collections;
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
        MentalDisorder mentalDisorder = mentalDisorders.GetMentalDisorder();
        Debug.Log(mentalDisorder.name);
        foreach(ObjectUsable obj in mentalDisorder.goodObjects)
        {
            Debug.Log(obj.name);
            Debug.Log(obj.effect);
            Debug.Log(obj.usage);
        }
        foreach (ObjectUsable obj in mentalDisorder.badObjects)
        {
            Debug.Log(obj.name);
            Debug.Log(obj.effect);
            Debug.Log(obj.usage);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
