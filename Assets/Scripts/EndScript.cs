using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EndScript : MonoBehaviour
{
    public TMP_Text Skor,Highskor;
    void Start()
    {
        Highskor.text = "High Score "+PlayerPrefs.GetInt("HighScore").ToString();
        Skor.text = "Score "+PlayerPrefs.GetInt("Skor").ToString();
    }
}
