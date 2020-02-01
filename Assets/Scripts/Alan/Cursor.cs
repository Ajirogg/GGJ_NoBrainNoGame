using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    private float clickCooldown = 0.5f;
    private float clickNext = 0.5f;

    private Ray hit;
    private RaycastHit hitInfo;
    private Vector2 mousePosition2D;


    private void Update()
    {
        hit = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(Camera.main.transform.position, Input.mousePosition, Color.green);

        if (Input.GetButtonDown("Fire1") && Time.time > clickNext)
        {
            clickNext = Time.time + clickCooldown;
            if (Physics.Raycast(hit, out hitInfo))
            {
                Debug.Log("Hit");
            }
        }
    }

    public void Test()
    {
        Debug.Log("Test");
    }
}

