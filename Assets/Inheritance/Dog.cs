using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    // K�peklere �zel bir havlama metodu
    public void Bark()
    {
        Debug.Log($"{Name} is barking!");
    }
}
