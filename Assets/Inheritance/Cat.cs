using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    public void Meow()
    {
        Debug.Log($"{Name} is meowing!");
    }
}
