using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public GameObject Menus,Options;
    public void Baslat()
    {
        SceneManager.LoadScene("Oyun");
    }
    public void Ayarlar()
    {
        Menus.SetActive(false);
        Options.SetActive(true);
    }
    public void AyarlarGeri()
    {
        Menus.SetActive(true);
        Options.SetActive(false);
    }
    public void Kapat()
    {
         Application.Quit();
    }
    public void MenuDon()
    {
        SceneManager.LoadScene("Menu");
    }
   

}
