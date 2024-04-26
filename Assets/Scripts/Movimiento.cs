using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Movimiento : MonoBehaviour
{
    public Rigidbody body;
    public float velocidad = 1;
    public float jumpForce = 1000;
    void Start()
    {
        
    }
    float horizontal;
    


    private void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        Vector3 mov = new Vector3(1, 0, 0) * Time.deltaTime * velocidad;
        Vector3 salto = new Vector3(0, 1, 0) * Time.deltaTime * jumpForce;
        body.velocity = mov;

        if (Input.GetKeyDown("space"))
        {
            body.velocity = salto;
        }
    }
}
