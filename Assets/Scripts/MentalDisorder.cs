using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentalDisorder : MonoBehaviour
{
    public new string name;
    public ObjectUsable[] goodObjects;
    public ObjectUsable[] badObjects;

    public MentalDisorder(string name, ObjectUsable goodObj1, ObjectUsable goodObj2, ObjectUsable badObj1, ObjectUsable badObj2)
    {
        this.name = name;
        goodObjects = new ObjectUsable[] { goodObj1, goodObj2 };
        badObjects = new ObjectUsable[] { badObj1, badObj2 };
    }
}
