using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombSpawn : MonoBehaviour
{
    [SerializeField] private GameObject bombPrefab;
    private float bombDelay;
    [SerializeField] private Transform[] spawnPoints;
    void Start()
    {
        bombDelay = 5f;
        StartCoroutine(spawnBomb());
    }

    IEnumerator spawnBomb()
    {
        while (true)
        {
            yield return new WaitForSeconds(bombDelay);

            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];
            GameObject bombTime = Instantiate(bombPrefab, spawnPoint.position, spawnPoint.rotation);

            Destroy(bombTime, 5f);
        }

    }
}
