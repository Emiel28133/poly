using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit, IMovable, IDamagable
{
    public float rotationSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public override void Move()
    {
        if (health > 0)
        {
            transform.position += transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical");
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
        }
    }
}
