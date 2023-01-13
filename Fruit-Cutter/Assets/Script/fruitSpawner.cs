using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] fruitPrefab;
    //[SerializeField] private GameObject bombPrefab;
    //[SerializeField] private Transform[] bombPoints;
    [SerializeField] private Transform[] spawnPoints;
    private float miniDelay = .1f;
    private float maxDelay = 1f;

    private void Start()
    {
        StartCoroutine(spawnFruits());

    }

    IEnumerator spawnFruits()
    {
        while (true)
        {
            float delay = Random.Range(miniDelay, maxDelay);
            int randomFruit = Random.Range(0, fruitPrefab.Length);
            yield return new WaitForSeconds(delay);
            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];
            GameObject spawnFruit = Instantiate(fruitPrefab[randomFruit], spawnPoint.position, spawnPoint.rotation);
            Destroy(spawnFruit, 5f);


        }

    }
}
