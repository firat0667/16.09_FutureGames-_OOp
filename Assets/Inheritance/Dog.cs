using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    // Köpeklere özel bir havlama metodu
    public void Bark()
    {
        Debug.Log($"{Name} is barking!");
    }
}
