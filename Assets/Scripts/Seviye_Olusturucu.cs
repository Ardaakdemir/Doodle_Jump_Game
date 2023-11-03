using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seviye_Olusturucu : MonoBehaviour
{
    public GameObject platform;
    public int platformSayisi; 
    public float minX,maxX;
    public float minY,maxY;                      

    void Start()
    {
        Vector3 klonPozisyon = new Vector3();
        for(int i=0; i < platformSayisi; i++)  
        {
            klonPozisyon.x = Random.Range(minX,maxX);
            klonPozisyon.y = Random.Range(minY,maxY);
            Instantiate(platform,klonPozisyon,Quaternion.identity);
        }  
   
    }

}
