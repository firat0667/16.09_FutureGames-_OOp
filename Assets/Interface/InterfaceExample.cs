using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceExample : MonoBehaviour
{
    void Start()
    {
        DogInterface dog = new DogInterface();
        dog.Name = "Buddy";
        dog.Speak();
        dog.Eat();
        dog.Move();

        CatInterface cat = new CatInterface();
        cat.Name = "Whiskers";
        cat.Speak();
        cat.Eat();
        cat.Move();
    }
}
