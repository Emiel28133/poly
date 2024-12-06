using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brute : EnemyParent
{

    void Start()
    {
        health = 10; // Extra veel levens
        speed = 1f;  // Langzaam lopen
    }

    private void Update()
    {
        
    }
}
