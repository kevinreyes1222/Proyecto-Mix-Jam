using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.left * speed;

    }
    // Update is called once per frame
    void Update()
    {
    }
}
