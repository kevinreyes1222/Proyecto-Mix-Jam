using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuPrincipal : MonoBehaviour
{
    public GameObject menuPrincipal;
    public GameObject menuOpciones;
    public void jugar ()
    {
        menuPrincipal.SetActive(false);
    }

    public void salir() 
    {
        Debug.Log("salir...");
        Application.Quit();
    }       
    
    public void opciones()
    {
        menuPrincipal.SetActive(false);
        menuOpciones.SetActive(true);
    }

    public void volver()
    {
        menuOpciones.SetActive(false );
        menuPrincipal.SetActive(true);
    }
}
