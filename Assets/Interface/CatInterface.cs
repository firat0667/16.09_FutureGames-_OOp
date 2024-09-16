using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatInterface : IAnimal
{
    public string Name;

    public void Speak()
    {
        Debug.Log($"{Name} is meowing!");
    }

    public void Eat()
    {
        Debug.Log($"{Name} is eating cat food.");
    }

    public void Move()
    {
        Debug.Log($"{Name} is walking gracefully.");
    }
}
