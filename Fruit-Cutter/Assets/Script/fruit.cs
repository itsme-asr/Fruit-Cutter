using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruit : MonoBehaviour
{
    [SerializeField] private GameObject fruitSlicedPreFab;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Blade")
        {
            Instantiate(fruitSlicedPreFab);
            Destroy(gameObject);

        }
    }
}
