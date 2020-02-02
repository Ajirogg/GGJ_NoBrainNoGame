using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagAsMeshName : MonoBehaviour
{

    ObjectList objList = new ObjectList();
    SpriteRenderer Actual;
    public GameObject actualGo;

    // Start is called before the first frame update
    void Start()
    {
//        actualGo = this.GetComponent<GameObject>();
  //      Debug.Log(actualGo.name);

        Actual = actualGo.GetComponent<SpriteRenderer>();
        foreach(ObjectUsable obj in objList.objects){
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
