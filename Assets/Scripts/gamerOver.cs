using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class gamerOver : MonoBehaviour
{
    public GameObject GameOver;
    public GameObject menu;
    
    public void volverMenu()
    {
        menu.SetActive(true);
    }

    public void volverAjugar()
    {
        GameOver.SetActive(false);
        SceneManager.LoadScene("SampleScene");
        //Time.timeScale = 1;
    }


    private void Update()
    {
        if (Personaje.isGameOver)
        {
            Invoke("gameOverInvoke", 1.15f);
            Scroll.canScroll = false;
        }
    }
    
            
        
    

  void  gameOverInvoke() { 
            GameOver.SetActive(true);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Invoke("gameOverInvoke", 1.15f);
            Scroll.canScroll = false;
        }
        
    }
}
