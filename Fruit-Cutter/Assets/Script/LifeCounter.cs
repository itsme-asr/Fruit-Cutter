using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LifeCounter : MonoBehaviour
{
    [Header("Gameplay")]
    [SerializeField] private int numberOfLives = 5;

    [Header("Visuals")]
    [SerializeField] private GameObject lifePrefab;
    [SerializeField] private GameObject gameOverGrp;

    private List<GameObject> lives;
    void Start()
    {
        lives = new List<GameObject>();
        for (int i = 0; i < numberOfLives; i++)
        {
            GameObject lifeInstance = Instantiate(lifePrefab, transform);
            lives.Add(lifeInstance);

        }
    }

    public void LoseLife()
    {
        numberOfLives--;
        GameObject lastlife = lives[lives.Count - 1];
        lives.Remove(lastlife);
        Destroy(lastlife);

        if (lives.Count == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}



