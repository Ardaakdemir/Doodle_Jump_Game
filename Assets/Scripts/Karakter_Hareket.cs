using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;
public class Karakter_Hareket : MonoBehaviour
{
    public float yatayHiz;
    private float horizontalInput;
    public static int skor;
    public TextMeshProUGUI skorYazi;
    void Start()
    {
       skor = 0;
    }
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * Time.deltaTime * horizontalInput * yatayHiz);
        skorYazi.text = "Score "+skor;
    }
    void OnCollisionEnter2D(Collision2D temas) {
        if (temas.gameObject.tag == "Platform")
        {
            skor += UnityEngine.Random.Range(5, 15);
        }
         if (temas.gameObject.tag == "Oldurucu")
        {
             if(skor > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore",skor);
        }
            PlayerPrefs.SetInt("Skor",skor);
            SceneManager.LoadScene("End");
        }
 }
}
