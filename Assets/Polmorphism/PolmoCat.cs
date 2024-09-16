using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolmoCat : PolmoAnimal
{
    // Overriding the Speak method for Cat
    public override void Speak()
    {
        Debug.Log($"{Name} is meowing!");
    }
}
