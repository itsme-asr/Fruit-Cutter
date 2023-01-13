using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombSpawn : MonoBehaviour
{
    [SerializeField] private GameObject bombPrefab;
    [SerializeField] private float bombDelay;
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

            Debug.Log(bombDelay);
            Debug.Log(GameObject.Find("Text").transform.GetComponent<FruitPoints>().ScorePoints);

            int score = GameObject.Find("Text").transform.GetComponent<FruitPoints>().ScorePoints;
            Debug.Log(score);

            delayBomb(score);

            Destroy(bombTime, 5f);
        }

    }

    private void delayBomb(int score)
    {
        if (score == 75)
        {
            bombDelay = bombDelay - .1f;
            Debug.Log(bombDelay);
        }
    }
}
