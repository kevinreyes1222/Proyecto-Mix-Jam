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
        }

        
       
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player")) 
        {
            muerte();
            Invoke("destruir", 2.30f);
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
