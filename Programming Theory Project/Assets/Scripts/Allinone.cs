using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Allinone : MonoBehaviour
{
    // Abstraction: Abstract class to define the interface for animal classes
    public abstract class Animal
    {
        public abstract void Speak();
    }

    // Encapsulation: Class to encapsulate data and methods that manipulate that data
    public class Cat : Animal
    {
        private string name;

        public Cat(string name)
        {
            this.name = name;
        }

        public override void Speak()
        {
            Debug.Log("Meow");
        }
    }

    // Inheritance: Child class (Dog) deriving behavior from parent class (Animal)
    public class Dog : Animal
    {
        public override void Speak()
        {
            Debug.Log("Woof");
        }
    }

    // Polymorphism: Method overloading and overriding
    public class Parrot : Animal
    {
        public override void Speak()
        {
            Debug.Log("Squawk");
        }

        public void Speak(string words)
        {
            Debug.Log("Says: " + words);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Using the classes
        Cat cat = new Cat("Whiskers");
        cat.Speak(); // Output: "Meow"

        Dog dog = new Dog();
        dog.Speak(); // Output: "Woof"

        Parrot parrot = new Parrot();
        parrot.Speak(); // Output: "Squawk"
        parrot.Speak("Hello"); // Output: "Says: Hello"
    }

    // Update is called once per frame
    void Update()
    {

    }
}