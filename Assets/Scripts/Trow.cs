using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class Trow : MonoBehaviour
{
    public GameObject ballPrefab;

    public GameObject referencePosition;

    public Animator animator;

    private void Start()
    {
        ballPrefab.transform.position = referencePosition.transform.position;
    }

    private void Update()
    {
        if (animator)
        {
            
        }
        Invoke("instanceBall", 3);

    }

    void instanceBall()
    {
        Instantiate(ballPrefab);
    }
}
