using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    
    public float speed = 6;
    public Vector3 mov = new Vector3(1, 0.5f, 0);

    private void Start()
    {
        
        

    }
    // Update is called once per frame
    void Update()
    {
        //rb.velocity = mov * speed;
    }

    private void FixedUpdate()
    {
        
        transform.Translate(mov * speed * Time.deltaTime);
       // rb.MovePosition(mov * speed);
    }
}
