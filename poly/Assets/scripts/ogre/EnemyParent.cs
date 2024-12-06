using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    public int health = 3;
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        WalkingToYourGrave();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Projectile"))
        {
            health--;
            Destroy(other.gameObject);
        }
    }

    private void WalkingToYourGrave()
    {
        if (health > 0)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
