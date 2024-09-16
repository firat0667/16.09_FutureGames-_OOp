using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolmoBird : PolmoAnimal
{
    // Overriding the Speak method for Bird
    public override void Speak()
    {
        Debug.Log($"{Name} is chirping!");
    }
}
