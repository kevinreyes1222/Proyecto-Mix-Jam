using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corredora : MonoBehaviour
{
    private Animator animator;
    public GameObject triggerDa�o;
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            triggerDa�o.SetActive(true);
            Invoke("triggerda�ofalse", 1);
        }

        
       
    }
    void triggerda�ofalse()
    {
        triggerDa�o.SetActive(false);
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
