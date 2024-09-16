using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolmoAnimal
{
    public string Name;

    // Virtual method: Speak
    public virtual void Speak()
    {
        Debug.Log($"{Name} is making a sound.");
    }
}
