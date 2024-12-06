using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brute : Unit, IMovable, IDamagable
{
    // Start is called before the first frame update
    void Start()
    {
        health = 10; // Extra veel levens
        speed = 1f;  // Langzaam lopen
    }
}
