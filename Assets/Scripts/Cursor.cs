using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    [SerializeField] GameObject calpinMove = null;
    [SerializeField] GameObject calpin03 = null;
    [SerializeField] GameObject calpin04 = null;

    public bool isCalpinOpen = false;

    private Ray ray;
    private RaycastHit hitInfo;

    public Backend back;


    private void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (!isCalpinOpen)
        {
            if (Physics.Raycast(ray, out hitInfo))
            {
                if (Input.GetMouseButton(0))
                {
                    SetSateTrue(hitInfo.transform.tag);
                    if (hitInfo.transform.tag == "Psychologist")
                    {
                        calpinMove.GetComponent<MoveCalpin>().ShowHideCalpin();
                        isCalpinOpen = true;
                    }
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
                    ApplyObjEffect(obj.name, objs);
                    back.changeState(obj.name);
                }
                else
                {

                }
            }
        }
    }


    public void ApplyObjEffect(string tag, ObjectUsable[] objs)
    {
        Patient actualPatient = back.patient;
        if (back.patient.mentalDisorder.name == "Schizophrenia")
        {
            foreach (ObjectUsable obj in back.patient.mentalDisorder.badObjects)
            {
                if (obj.name == tag)
                {
                    if (obj.name == "Red medicine")
                    {
                        if (actualPatient.ClientMindHealthPlus == 50)
                        {
                            if (back.objectLister.GetObjectUsable(objs, "Blue medicine").state == true)
                            {
                                actualPatient.ClientMindHealthMin -= obj.effect;
                                calpin03.GetComponent<CalpinScript>().EventCalpin(tag + " is bad");
                                calpin04.GetComponent<CalpinScript>().EventCalpin(tag + " is bad");

                            }
                            else
                            {
                                actualPatient.ClientMindHealthPlus += obj.effect;
                                calpin03.GetComponent<CalpinScript>().EventCalpin(tag + " is good");
                                calpin04.GetComponent<CalpinScript>().EventCalpin(tag + " is good");
                            }
                        }
                        else
                        {
                            actualPatient.ClientMindHealthPlus += obj.effect;
                            calpin03.GetComponent<CalpinScript>().EventCalpin(tag + " is good");
                            calpin04.GetComponent<CalpinScript>().EventCalpin(tag + " is good");
                        }
                    }
                    else
                    {
                        actualPatient.ClientMindHealthMin += obj.effect;
                        calpin03.GetComponent<CalpinScript>().EventCalpin(tag + " is bad");
                        calpin04.GetComponent<CalpinScript>().EventCalpin(tag + " is bad");
                    }
                }
            }

            foreach (ObjectUsable mObj in back.patient.mentalDisorder.goodObjects)
            {
                if (mObj.name == tag)
                {
                    Debug.Log("UUUUUUUUUUUUUUUUUUUUUU");
                    Debug.Log(mObj.name);
                    if (mObj.name == "Blue medicine")
                    {
                        if (actualPatient.ClientMindHealthPlus == 50)
                        {
                            if (back.objectLister.GetObjectUsable(objs, "Red medicine").state == true)
                            {
                                actualPatient.ClientMindHealthMin -= mObj.effect;
                                calpin03.GetComponent<CalpinScript>().EventCalpin(tag + " is bad");
                                calpin04.GetComponent<CalpinScript>().EventCalpin(tag + " is bad");
                            }
                            else
                            {
                                actualPatient.ClientMindHealthPlus += mObj.effect;
                                calpin03.GetComponent<CalpinScript>().EventCalpin(tag + " is good");
                                calpin04.GetComponent<CalpinScript>().EventCalpin(tag + " is good");
                            }
                        }
                        else
                        {
                            actualPatient.ClientMindHealthPlus += mObj.effect;
                            calpin03.GetComponent<CalpinScript>().EventCalpin(tag + " is good");
                            calpin04.GetComponent<CalpinScript>().EventCalpin(tag + " is good");
                        }
                    }
                    else
                    {
                        actualPatient.ClientMindHealthPlus += mObj.effect;
                        calpin03.GetComponent<CalpinScript>().EventCalpin(tag + " is good");
                        calpin04.GetComponent<CalpinScript>().EventCalpin(tag + " is good");
                    }
                }
            }
        }
        else
        {
            foreach (ObjectUsable obj in back.patient.mentalDisorder.badObjects)
            {
                if (obj.name == tag)
                {
                    actualPatient.ClientMindHealthMin += obj.effect;
                    calpin03.GetComponent<CalpinScript>().EventCalpin(tag + " is bad");
                    calpin04.GetComponent<CalpinScript>().EventCalpin(tag + " is bad");
                }
            }
            foreach (ObjectUsable mObj in back.patient.mentalDisorder.goodObjects)
            {
                if (mObj.name == tag)
                {
                    actualPatient.ClientMindHealthPlus += mObj.effect;
                    calpin03.GetComponent<CalpinScript>().EventCalpin(tag + " is good");
                    calpin04.GetComponent<CalpinScript>().EventCalpin(tag + " is good");
                }
            }
        }
        if (back.patient.mentalDisorder.neutralObject.name == tag)
        {
            calpin03.GetComponent<CalpinScript>().EventCalpin(tag + " is neutral");
            calpin04.GetComponent<CalpinScript>().EventCalpin(tag + " is neutral");
        }
    }
}
