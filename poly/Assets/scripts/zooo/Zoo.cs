using System.Collections.Generic;
using UnityEngine;

public abstract class Animal
{
    public abstract void Move();

    public void Eat()
    {
        Debug.Log("Njam Njam");
    }
}

public class Bird : Animal
{
    public override void Move()
    {
        Debug.Log("Flaps its wings");
    }
}

public class Dog : Animal
{
    public override void Move()
    {
        Debug.Log("Steps on own nuts");
    }
}

public class Elephant : Animal
{
    public override void Move()
    {
        Debug.Log("Stomps Child");
    }
}

public class Zoo : MonoBehaviour
{
    private List<Animal> animals;

    void Start()
    {
        animals = new List<Animal>
        {
            new Bird(),
            new Dog(),
            new Elephant()
        };

        foreach (var animal in animals)
        {
            animal.Eat();
            animal.Move();
        }
    }
}
