using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corredora : MonoBehaviour
{
    private Animator animator;
    public GameObject triggerDaño;
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            triggerDaño.SetActive(true);
            Invoke("triggerdañofalse", 1);
        }

        
       
    }
    void triggerdañofalse()
    {
        triggerDaño.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("player") && !Personaje.isGameOver) 
        {
            muerte();
            Invoke("destruir",0.1f);
        }
        
            
        
    }
    void muerte()
    {
        animator.SetBool("Muerte", true);
    }

    private void destruir()
    {
        Destroy(gameObject);
    }
}
