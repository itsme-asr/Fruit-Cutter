using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitPoints : MonoBehaviour
{
    [SerializeField] private AudioSource slice;
    private int scorePoints;
    public int ScorePoints
    {
        get
        {

            return scorePoints;
        }
        set
        {
            GetComponent<Text>().text = "P O I N T : " + scorePoints;
        }
    }
    void Start()
    {

        ScorePoints = 74;
    }
}
