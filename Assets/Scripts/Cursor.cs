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
<<<<<<< HEAD
                    ApplyObjEffect(obj.name, objs);
                    back.changeState(obj.name);
=======
                    ApplyObjEffect(obj.name);
                    //Debug.Log(obj.state);
>>>>>>> ALan
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

<<<<<<< HEAD
        if(back.patient.mentalDisorder.name == "Schizophrenia")
        {
            foreach (ObjectUsable obj in back.patient.mentalDisorder.badObjects)
            {
                if (obj.name == tag)
                { 
                    if(obj.name == "Red medicine")
                    {
                        if (actualPatient.ClientMindHealthPlus == 50)
                        {
                            if (back.objectLister.GetObjectUsable(objs, "Blue medicine").state == true)
                            {
                                actualPatient.ClientMindHealthMin -= obj.effect;
                            } else
                            {
                                actualPatient.ClientMindHealthPlus += obj.effect;
                            }
                        } else
                        {
                            actualPatient.ClientMindHealthPlus += obj.effect;
                        }
                    } else
                    {
                        actualPatient.ClientMindHealthMin += obj.effect;
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
                            }
                            else
                            {
                                actualPatient.ClientMindHealthPlus += mObj.effect;
                            }
                        }
                        else
                        {
                            actualPatient.ClientMindHealthPlus += mObj.effect;
                        }
                    }
                    else
                    {
                        actualPatient.ClientMindHealthPlus += mObj.effect;
                    }
                }
            }
        } else
        {
            foreach(ObjectUsable obj in back.patient.mentalDisorder.badObjects)
            {
                if(obj.name == tag){
                    actualPatient.ClientMindHealthMin += obj.effect;
                }
            }
            foreach(ObjectUsable mObj in back.patient.mentalDisorder.goodObjects)
            {
                if(mObj.name == tag){
                    actualPatient.ClientMindHealthPlus += mObj.effect;
                }
=======
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
>>>>>>> ALan
            }
        }
        if (back.patient.mentalDisorder.neutralObject.name == tag)
        {
            calpin03.GetComponent<CalpinScript>().EventCalpin(tag + " is neutral");
            calpin04.GetComponent<CalpinScript>().EventCalpin(tag + " is neutral");
        }
    }
}
