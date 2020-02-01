using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CalpinScript : MonoBehaviour
{

    [SerializeField]
    public GameObject  PrenomNom;
    public Text  PrenomNomText;

    string Text1;
    string Text2;
    string Text3;

    string compteurpages;
    PatientInfo patient;

    
    // Start is called before the first frame update
    void Start()
    {
        patient = GetComponent<PatientInfo>();
        PrenomNomText = PrenomNom.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
       PrenomNomText.text = patient.actualname + " " + patient.actualFirstname; 
    }
}
