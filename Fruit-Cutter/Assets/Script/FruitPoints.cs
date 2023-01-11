using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitPoints : MonoBehaviour
{
    //[SerializeField] private Text scoreText;
    private int scorePoints = 0;
    public int ScorePoints
    {
        get { return scorePoints; }
        set
        {
            scorePoints = value;
            GetComponent<Text>().text = "P O I N T : " + scorePoints;
        }
    }

    void Start()
    {
        ScorePoints = 0;
    }

}
