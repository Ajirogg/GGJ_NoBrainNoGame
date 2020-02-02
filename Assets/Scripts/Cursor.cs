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
        foreach(ObjectUsable obj in objs)
        {
            if(obj.name == tag){
                if(obj.state == false){
                obj.state = true;
                ApplyObjEffect(obj.name);
                //Debug.Log(obj.state);
                }else{

                }
            }
        } 
    }

    public void ApplyObjEffect(string tag)
    {
        Patient actualPatient = back.patient;
        ObjectUsable[] badobjs = back.patient.mentalDisorder.badObjects;
        ObjectUsable[] goodobjs = back.patient.mentalDisorder.goodObjects;

        foreach(ObjectUsable obj in badobjs)
        {
            if(obj.name == tag){
                        actualPatient.ClientMindHealthPlus += obj.effect;
                    
                }
        }
        foreach(ObjectUsable mObj in goodobjs){
            if(mObj.name == tag){
                actualPatient.ClientMindHealthMin += mObj.effect;
            }
        }
    }
        
    
}

