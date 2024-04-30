using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    private Animator animator;
    public float fuerzaSalto = 10;
    public bool enSuelo;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        if (enSuelo && Input.GetKeyDown(KeyCode.W))
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
        rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        enSuelo = false;
        animator.SetBool("isJumping", true);
        
    }
    void jumpfasle()
    {
        animator.SetBool("isJumping", false);
    }

    void Attack()
    {
        animator.SetBool("isAttacking", true);
        Invoke("attackfalse", 1.2f);

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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            enSuelo = true;
            jumpfasle();
        }

    }
}