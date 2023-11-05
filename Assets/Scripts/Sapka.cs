using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class Sapka : MonoBehaviour
{
    public Transform krktr,Sapkaa,SapkaPlatform;
    public Rigidbody2D Karakter;

    void OnCollisionEnter2D(Collision2D temas) {
        if(temas.gameObject.tag == "Karakter")
        {    
           Sapkaa.SetParent(krktr);
           Sapkaa.localPosition = new Vector3((float)-0.32,(float)1.02,0);
        } 
        }
     void Update()
     {
        if (Karakter.velocity.y < 1)
         {
           Sapkaa.SetParent(SapkaPlatform);
           Sapkaa.localPosition = new Vector3(0,(float)0.3499999,0);
         }
         if(Sapkaa.parent == krktr){

         if (Karakter_Hareket.horizontalInput > 0)
            {
                Sapkaa.localPosition = new Vector3((float)-0.32,(float)1.02,0);
            }
            if (Karakter_Hareket.horizontalInput < 0)
            {
            Sapkaa.localPosition = new Vector3((float)0.327,(float)0.985,0);
            }
         }
     }
          
    }
  
