using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitPoints : MonoBehaviour
{
    private int scorePoints;
    public int ScorePoints
    {
        get
        { return scorePoints; }
        set
        {
            scorePoints = value;
            GetComponent<Text>().text = "P O I N T : " + scorePoints;
            PlayerPrefs.SetInt("highscore", scorePoints);
        }
    }
    void Start()
    {
        ScorePoints = 0;
    }
}
