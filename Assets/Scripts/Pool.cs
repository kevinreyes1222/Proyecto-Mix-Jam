using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    //[SerializeField] private GameObject obstaclePrefab;
    public List<GameObject> obstaclePrefab;
    
  
    public ReferencePoint referencePoint;
   
    

   

    void Start()
    {
            SpawnObstacle(Random.Range(0,obstaclePrefab.Count));

        

    }


    

    public void SpawnObstacle(int num)
    {
        
       


        referencePoint = Instantiate(obstaclePrefab[num], referencePoint.spawnPoint.position,Quaternion.identity).GetComponent<ReferencePoint>();

        


    }
}
