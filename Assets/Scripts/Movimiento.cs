using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Movimiento : MonoBehaviour
{
    public Rigidbody body;
    
    public float jumpForce = 1000;
    private float posInicialX;
    void Start()
    {
        posInicialX = transform.position.x;
    }
   
    


    private void FixedUpdate()
    {
       
        
        Vector3 salto = new Vector3(0, 1, 0) * Time.deltaTime * jumpForce;
     

        if (Input.GetKeyDown("space"))
        {
            body.velocity = salto;
        }

        Vector3 newPos = transform.position;
        newPos.x = posInicialX;
        transform.position = newPos;
    }
}
