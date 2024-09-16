using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritanceExample : MonoBehaviour
{
    void Start()
    {
        // Creating a Dog object
        Dog dog = new Dog();
        dog.Name = "Buddy";
        dog.Age = 3;

        // Using both inherited methods from Animal class and specific methods from Dog class
        dog.Speak();  // Inherited from Animal class
        dog.Eat();    // Inherited from Animal class
        dog.Bark();   // Specific to Dog class
        dog.GetAge(); // Inherited from Animal class

        // Creating a Cat object
        Cat cat = new Cat();
        cat.Name = "Whiskers";
        cat.Age = 2;

        // Using both inherited methods from Animal class and specific methods from Cat class
        cat.Speak();  // Inherited from Animal class
        cat.Eat();    // Inherited from Animal class
        cat.Meow();   // Specific to Cat class
        cat.GetAge(); // Inherited from Animal class
    }
}
