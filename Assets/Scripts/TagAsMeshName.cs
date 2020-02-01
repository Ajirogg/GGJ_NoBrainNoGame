using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagAsMeshName : MonoBehaviour
{

    ObjectList objectList;
    SpriteRenderer Actual;
    GameObject actualGo;

    // Start is called before the first frame update
    void Start()
    {

        actualGo = GetComponent<GameObject>();
        Actual = GetComponent<SpriteRenderer>();
        foreach(ObjectUsable obj in objectList.objects){
            if(Actual.material.name == obj.name){
                actualGo.tag = obj.name;
            };
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
