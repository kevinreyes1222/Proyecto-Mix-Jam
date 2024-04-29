using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }
        if (Input.GetKey(KeyCode.S))
        {
            Crouch();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            crouchfalse();
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();

        }
    }
    void Jump()
    {
        animator.SetBool("isJumping", true);
        Invoke("jumpfasle", 4.2f);
    }
    void jumpfasle()
    {
        animator.SetBool("isJumping", false);
    }

    void Attack()
    {
        animator.SetBool("isAttacking", true);
        Invoke("attackfalse", 2.10f);
    }
    void attackfalse()
    {
        animator.SetBool("isAttacking", false);
    }

    void Crouch()
    {
        animator.SetBool("isCrouching", true);
    }
    void crouchfalse()
    {
        animator.SetBool("isCrouching", false);
    }

}
