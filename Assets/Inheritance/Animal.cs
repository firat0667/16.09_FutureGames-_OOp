using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    public string Name;
    public int Age;

    // Hayvanlar için genel bir konuşma metodu
    public void Speak()
    {
        Debug.Log($"{Name} is making a sound.");
    }

    // Hayvanların yemek yeme metodu
    public void Eat()
    {
        Debug.Log($"{Name} is eating.");
    }

    // Hayvanın yaşını döndürme metodu
    public void GetAge()
    {
        Debug.Log($"{Name} is {Age} years old.");
    }
}
