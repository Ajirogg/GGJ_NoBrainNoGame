using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectList : MonoBehaviour
{
    public ObjectUsable[] objects;

    public ObjectUsable[] neutralSchizo;
    public ObjectUsable[] neutralManiac;
    public ObjectUsable[] neutralAddict;
    public ObjectUsable[] neutralADD;

    public ObjectList() { }


    private void Awake() {
      CreateObjectList();  
    }
   public ObjectUsable[] CreateObjectList()
    {
        ObjectUsable incense = new ObjectUsable("Incense", 0, "Light incense");
        ObjectUsable rubiksCube = new ObjectUsable("Rubik's Cube", 0, "Propose a distraction");
        ObjectUsable picture = new ObjectUsable("Picture", 0, "Straighten the picture");
        ObjectUsable carpet = new ObjectUsable("Carpet", 0, "Lay down the mat");
        ObjectUsable familyPortrait = new ObjectUsable("Family Portrait", 0, "Show family portrait");
        ObjectUsable terminationLetter = new ObjectUsable("Termination Letter", 0, "Recall the termination");
        ObjectUsable alcohol = new ObjectUsable("Alcohol", 0, "Offer a glass");
        ObjectUsable cigarette = new ObjectUsable("Cigarette", 0, "Offer a cigarette");
        ObjectUsable cookie = new ObjectUsable("Cookies", 0, "Offer to eat");
        ObjectUsable radio = new ObjectUsable("Radio", 0, "Turn off the radio");
        ObjectUsable toy = new ObjectUsable("Wood toy", 0, "Propose an activity");
        ObjectUsable window = new ObjectUsable("Window", 0, "Open the window");
        ObjectUsable medicine1 = new ObjectUsable("Blue medicine", 0, "Prescribing neuroleptics");
        ObjectUsable medicine2 = new ObjectUsable("Red medicine", 0, "Prescribing neuroleptics");
        ObjectUsable familyPortraitCrossed = new ObjectUsable("Crossed family portrait", 0, "Advise to take time alonet");
        ObjectUsable callingCard = new ObjectUsable("Calling card", 0, "Give calling card");

        objects = new ObjectUsable[] {
            incense,
            rubiksCube,
            picture,
            carpet,
            familyPortrait,
            terminationLetter,
            alcohol,
            cigarette,
            cookie,
            radio,
            toy,
            window,
            medicine1,
            medicine2,
            familyPortraitCrossed,
            callingCard
        };

        foreach(ObjectUsable obj in objects){
            Debug.Log(obj.name);
        }

        neutralSchizo = new ObjectUsable[] {
            incense,
            rubiksCube,
            picture,
            carpet,
            familyPortrait,
            terminationLetter,
            alcohol,
            cigarette,
            cookie,
            radio,
            toy,
            window
        };

        neutralADD = new ObjectUsable[] {
            incense,
            picture,
            carpet,
            familyPortrait,
            terminationLetter,
            alcohol,
            cigarette,
            medicine1,
            medicine2,
            familyPortraitCrossed,
            callingCard
        };

        neutralAddict = new ObjectUsable[] {
            incense,
            rubiksCube,
            picture,
            carpet,
            cookie,
            radio,
            toy,
            window,
            medicine1,
            medicine2,
            familyPortraitCrossed,
            callingCard
        };

        neutralManiac = new ObjectUsable[] {
            familyPortrait,
            terminationLetter,
            alcohol,
            cigarette,
            cookie,
            radio,
            window,
            medicine1,
            medicine2,
            familyPortraitCrossed,
            callingCard
        };
        return objects;
    }

    public ObjectUsable GetObjectUsable(ObjectUsable[] objs, string name)
    {
        for(int index = 0; index < objs.Length; index++)
        {
            if(objs[index].name == name)
            {
                return objs[index];
            }
        }
        return null;
    }

    public ObjectUsable GetObjUsableNeutral(ObjectUsable[] objs)
    {
        int index = Random.Range(0, objs.Length);
        return objs[index];
    }

}
