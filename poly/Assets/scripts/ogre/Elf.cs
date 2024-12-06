using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : EnemyParent
{
    private Renderer renderer;
    private bool isVisible = true;

    // Start is called before the first frame update
    void Start()
    {
        health = 2; // Weinig levens
        speed = 5f; // Snel lopen
        renderer = GetComponent<Renderer>();
        StartCoroutine(ToggleVisibility());
    }

    private void Update()
    {
        
    }

    private IEnumerator ToggleVisibility()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            isVisible = !isVisible;
            renderer.enabled = isVisible;
            yield return new WaitForSeconds(0.5f);
            isVisible = !isVisible;
            renderer.enabled = isVisible;
        }
    }
}
