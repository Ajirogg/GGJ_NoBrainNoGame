using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectUsable : MonoBehaviour
{
    public string name;
    public int effect;

    public ObjectUsable(string name, int effect)
    {
        this.name = name;
        this.effect = effect;
    }
}
