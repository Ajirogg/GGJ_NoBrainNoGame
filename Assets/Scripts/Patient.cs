using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patient : MonoBehaviour
{
    // Start is called before the first frame update
    public string name;
    public string firstname;

    public MentalDisorder ClientDisorder;

    public ObjectUsable[] UsableObjGood;
    public ObjectUsable[] UsableObjBad;

    public int ClientMindHealthMin;
    public int ClientMindHealthPlus;
    
    public MentalDisorder mentalDisorder;

    public Patient()
    {
        PatientInfo pInfo = new PatientInfo();
        name = pInfo.getRandomName();
        firstname = pInfo.getRandomFirstname();

        UsableObjGood = ClientDisorder.goodObjects;
        UsableObjBad = ClientDisorder.badObjects;
        ClientMindHealthMin =  0;
        ClientMindHealthPlus = 0;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
