using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolmoDog : PolmoAnimal
{
    public override void Speak()
    {
        Debug.Log($"{Name} is barking!");
    }
}
