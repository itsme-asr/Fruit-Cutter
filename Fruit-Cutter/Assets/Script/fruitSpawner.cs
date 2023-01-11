using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitSpawner : MonoBehaviour
{
    [SerializeField] private GameObject fruitPrefab;
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
            float deplay = Random.Range(miniDelay, maxDelay);
            yield return new WaitForSeconds(deplay);
            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];
            GameObject spawnFruit = Instantiate(fruitPrefab, spawnPoint.position, spawnPoint.rotation);
            Destroy(spawnFruit, 5f);
        }


    }
}
