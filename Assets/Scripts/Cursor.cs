using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    private float clickCooldown = 0.5f;
    private float clickNext = 0.5f;

    private Ray ray;
    private RaycastHit hitInfo;
    
    private Vector2 mousePosition2D;

    public Backend back;


    private void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hitInfo))
            {
                if(Input.GetMouseButton(0)){
                    SetSateTrue(hitInfo.transform.tag);
                    
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
            }
        }
    }
}

