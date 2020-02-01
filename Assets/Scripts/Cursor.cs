﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    private float clickCooldown = 0.5f;
    private float clickNext = 0.5f;

    private Ray ray;
    private RaycastHit hitInfo;
    private Vector2 mousePosition2D;


    private void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hitInfo))
            {
                Debug.Log(hitInfo.transform.tag);
                if(Input.GetMouseButton(0)){
                    SetSateTrue(hitInfo.transform.tag);
                }

            }
    }

    public void SetSateTrue(string tag)
    {
        ObjectList objs = GetComponent<ObjectList>() ;
        foreach(ObjectUsable obj in objs.objects)
        {
            if(obj.name == tag){
                if(obj.state == false){
                obj.state = true;
                }else{

                }
            }
        } 
    }
}
