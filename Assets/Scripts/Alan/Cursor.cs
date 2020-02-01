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


    private void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hitInfo))
            {
                Debug.Log(hitInfo);
            }
    }

    public void Test()
    {
        Debug.Log("Test");
    }
}

