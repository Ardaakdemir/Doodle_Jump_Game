using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Temizle : MonoBehaviour
{
    
    
     void OnTriggerEnter2D(Collider2D temas) {
        float RandomX = Random.Range(-4f,4f);
        float RandomY = Random.Range(9f,10f);
        float RandomYBoost = Random.Range (10f,40f);
        float RandomYSapkaPlat = Random.Range(60f,130f);
        
        if(temas.tag == "Platform")
        {
            temas.transform.position = new Vector3(RandomX,temas.transform.position.y + RandomY,temas.transform.position.z);
        }
        if(temas.tag == "wp")
        {
            temas.transform.position = new Vector3(temas.transform.position.x, temas.transform.position.y + 14.355f, temas.transform.position.z);
        }
        if(temas.tag == "Boost")
        {
            temas.transform.position = new Vector3(temas.transform.position.x, temas.transform.position.y + RandomYBoost, temas.transform.position.z);
        }
        if(temas.tag == "SapkaPlatform")
        {
            temas.transform.position = new Vector3(temas.transform.position.x, temas.transform.position.y + RandomYSapkaPlat, temas.transform.position.z);
        }
    }
}
