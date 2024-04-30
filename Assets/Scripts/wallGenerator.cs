using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallGenerator : MonoBehaviour
{

    public Pool pooler;
    public bool spawner;
    public bool destroyer;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            if (spawner)
            {
                

                pooler.SpawnObstacle(Random.Range(0, pooler.obstaclePrefab.Count));
                
            }else if (destroyer)
            {
                Destroy(other.transform.root.gameObject);
            }
            
        }

    }







}
