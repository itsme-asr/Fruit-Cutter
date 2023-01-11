using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fruit : MonoBehaviour
{
    public bool harmFul = true;
    [SerializeField] private GameObject fruitSlicedPreFab;
    [SerializeField] private float startForce = 15f;
    // [SerializeField] public Text scoreText;
    // public int scorePoints = 0;
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
            if (!harmFul)
            {
                GameObject.Find("Text").transform.GetComponent<FruitPoints>().ScorePoints += 1;
            }

            Vector3 direction = (col.transform.position - transform.position).normalized;
            Quaternion rotation = Quaternion.LookRotation(direction);
            GameObject sliceFruit = Instantiate(fruitSlicedPreFab, transform.position, rotation);

            Destroy(gameObject);
            Destroy(sliceFruit, 5f);
        }
    }


}
