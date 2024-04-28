using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamerOver : MonoBehaviour
{
    public GameObject GameOver;
    
    public void volverMenu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void volverAjugar()
    {
        GameOver.SetActive(false);
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }

    void OnCollisionEnter(Collision collison)
    {
        if (collison.gameObject.CompareTag("Player"))
        {
            GameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
