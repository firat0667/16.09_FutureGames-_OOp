using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolymorphismExample : MonoBehaviour
{
    void Start()
    {
        // Polymorphism through method overriding
        PolmoAnimal dog = new PolmoDog();
        dog.Name = "Buddy";

        PolmoAnimal cat = new PolmoCat();
        cat.Name = "Whiskers";

        PolmoAnimal bird = new PolmoBird();
        bird.Name = "Tweety";

        // Each class calls its own version of the Speak method
        dog.Speak();  // Dog's Speak: "Buddy is barking!"
        cat.Speak();  // Cat's Speak: "Whiskers is meowing!"
        bird.Speak(); // Bird's Speak: "Tweety is chirping!"

        // Example of storing different types in an array of the base class type
        PolmoAnimal[] animals = { dog, cat, bird };

        // Looping through the array and calling Speak()
        foreach (PolmoAnimal animal in animals)
        {
            animal.Speak(); // Each animal will call its own Speak() method
        }
    }
}
