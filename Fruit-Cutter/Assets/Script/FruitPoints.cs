using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitPoints : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    private int scorePoints;
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Fruit")
        {
            scorePoints++;
            scoreText.text = "P O I N T : " + scorePoints;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

    }
}
