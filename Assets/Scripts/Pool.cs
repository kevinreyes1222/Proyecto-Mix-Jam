using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    //[SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private List<GameObject> obstaclePrefab;
    [SerializeField] private int poolSize = 3;
    [SerializeField] private float spawnTime = 6.72f;
    [SerializeField] private float xSpawnPos = -7.34f;
    [SerializeField] private float ySpawnPos = 6f;


    private float timeElapsed;

    private int obstacleCount;


    private GameObject[] obstacles;

    void Start()
    {
        obstacles = new GameObject[poolSize];
        for (int i = 0; i < poolSize; i++)
        {
            int indexPrefab = Random.Range(0, 3);

            obstacles[i] = Instantiate(obstaclePrefab[indexPrefab]);
            obstacles[i].SetActive(false);
        }
    }


    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > spawnTime  /*&& !GameManager.Instance.isGameOver*/)
        {
            SpawnObstacle();
        }
    }

    void SpawnObstacle()
    {
        timeElapsed = 0f;

        
        Vector3 spawnPos = new Vector3(xSpawnPos, ySpawnPos);
        obstacles[obstacleCount].transform.position = spawnPos;

        if (!obstacles[obstacleCount].activeSelf)
        {
            obstacles[obstacleCount].SetActive(true);

        }

        obstacleCount++;

        if (obstacleCount == poolSize)
        {
            obstacleCount = 0;
        }

    }
}
