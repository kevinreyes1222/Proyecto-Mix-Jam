using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Movimiento : MonoBehaviour
{
    public Rigidbody body;
    public float velocidad = 1000;
    public float jumpForce = 1000;
    void Start()
    {
        
    }
    float horizontal;
    float vertical;
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
         Vector3 mov = new Vector3(horizontal, 0, 0) * Time.deltaTime * velocidad;
        Vector3 salto = new Vector3(0, 1, 0) * Time.deltaTime * jumpForce;
        body.velocity = mov;

        if (Input.GetKey(KeyCode.Space))
        {
            body.velocity = salto;
        }
    }
}
