using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour
{
    public Text hscore;
    void Start()
    {
        hscore.text = " " + PlayerPrefs.GetInt("highscore");
    }


}