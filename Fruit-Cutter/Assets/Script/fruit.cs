using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fruit : MonoBehaviour
{
    [SerializeField] private GameObject fruitSlicedPreFab;
    [SerializeField] private float startForce = 15f;
    //[SerializeField] public Text scoreText;
    //private int scorePoints = 0;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Blade")
        {
            //scorePoints++;
            //scoreText.text = "P O I N T : " + scorePoints;
            Vector3 direction = (col.transform.position - transform.position).normalized;
            Quaternion rotation = Quaternion.LookRotation(direction);
            GameObject sliceFruit = Instantiate(fruitSlicedPreFab, transform.position, rotation);


            Destroy(gameObject);
            Destroy(sliceFruit, 5f);
        }
    }

    // private void OnCollisionEnter(Collision col)
    // {
    //     if (col.gameObject.CompareTag("Blade"))
    //     {


    //     }
    // }
}
