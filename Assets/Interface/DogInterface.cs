using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class DogInterface : IAnimal
{
    public string Name;
    public void Speak()
    {
        Debug.Log($"{Name} is barking!");
    }

    public void Eat()
    {
        Debug.Log($"{Name} is eating dog food.");
    }

    public void Move()
    {
        Debug.Log($"{Name} is running.");
    }
}
