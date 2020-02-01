using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectUsable : MonoBehaviour
{
    public string name;
    public int effect;
    public string usage;

    public bool state;

    public ObjectUsable(string name, int effect, string desc)
    {
        this.name = name;
        this.effect = effect;
        usage = desc;
        state = false;
    }

    public void setEffet(int effect)
    {
        this.effect = effect;
    }

    
}
