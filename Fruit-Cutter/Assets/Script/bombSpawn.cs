using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombSpawn : MonoBehaviour
{
    [SerializeField] private GameObject bombPrefab;
    [SerializeField] private float bombDelay = 5f;
    [SerializeField] private Transform[] spawnPoints;
    void Start()
    {
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
            if (GameObject.Find("Text").transform.GetComponent<FruitPoints>().ScorePoints == 75)
            {
                bombDelay = bombDelay - .1f;
                Debug.Log(bombDelay);
            }

            // else if (
            //     GameObject.Find("Text").transform.GetComponent<FruitPoints>().ScorePoints == 150)
            // {
            //     bombDelay = bombDelay - .1f;
            //     Debug.Log(bombDelay);
            // }
            Destroy(bombTime, 5f);
        }

    }
}
