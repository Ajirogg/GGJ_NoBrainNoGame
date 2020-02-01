using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagAsMeshName : MonoBehaviour
{

    public ObjectList objList = new ObjectList();
    SpriteRenderer Actual;
    GameObject actualGo;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(objList.objects);
        actualGo = actualGo.GetComponent<GameObject>();
        Actual = Actual.GetComponent<SpriteRenderer>();
        foreach(ObjectUsable obj in objList.objects){
            Debug.Log(obj.name);
            if(Actual.sprite.name == obj.name){
                actualGo.gameObject.tag = obj.name;
            };
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
