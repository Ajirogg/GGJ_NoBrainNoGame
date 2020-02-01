using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patient : MonoBehaviour
{
    // Start is called before the first frame update
    public string name;
    public string firstname;

    public MentalDisorder mentalDisorder;

    public Patient()
    {
        PatientInfo pInfo = new PatientInfo();
        name = pInfo.getRandomName();
        firstname = pInfo.getRandomFirstname();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
