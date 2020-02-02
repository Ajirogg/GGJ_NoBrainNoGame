using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    [SerializeField] GameObject calpinMove = null;
    [SerializeField] GameObject calpin03 = null;
    [SerializeField] GameObject calpin04 = null;

    private Ray ray;
    private RaycastHit hitInfo;

    public Backend back;


    private void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hitInfo))
        {
            if (Input.GetMouseButton(0))
            {
                SetSateTrue(hitInfo.transform.tag);
                if (hitInfo.transform.tag == "Psychologist")
                {
                    calpinMove.GetComponent<MoveCalpin>().ShowHideCalpin();
                }
            }

        }
    }

    public void SetSateTrue(string tag)
    {
        ObjectUsable[] objs = back.patient.ObjectLister.objects;
        foreach (ObjectUsable obj in objs)
        {
            if (obj.name == tag)
            {
                if (obj.state == false)
                {
                    obj.state = true;
                    ApplyObjEffect(obj.name);
                    //Debug.Log(obj.state);
                }
                else
                {

                }
            }
        }
    }

    public void ApplyObjEffect(string tag)
    {
        Patient actualPatient = back.patient;
        ObjectUsable[] badobjs = back.patient.mentalDisorder.badObjects;
        ObjectUsable[] goodobjs = back.patient.mentalDisorder.goodObjects;

        foreach (ObjectUsable obj in badobjs)
        {
            if (obj.name == tag)
            {
                actualPatient.ClientMindHealthMin += obj.effect;
                calpin03.GetComponent<CalpinScript>().EventCalpin(tag + " is bad");
                calpin04.GetComponent<CalpinScript>().EventCalpin(tag + " is bad");
            }
        }
        foreach (ObjectUsable mObj in goodobjs)
        {
            if (mObj.name == tag)
            {
                actualPatient.ClientMindHealthPlus += mObj.effect;
                calpin03.GetComponent<CalpinScript>().EventCalpin(tag + " is good");
                calpin04.GetComponent<CalpinScript>().EventCalpin(tag + " is good");
            }
        }
        if (back.patient.mentalDisorder.neutralObject.name == tag)
        {
            calpin03.GetComponent<CalpinScript>().EventCalpin(tag + " is neutral");
            calpin04.GetComponent<CalpinScript>().EventCalpin(tag + " is neutral");
        }
    }
}
