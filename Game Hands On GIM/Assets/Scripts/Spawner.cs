using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePatterns;

    private float TimeBetweenSpawn;

    public float StartTimeBetweenSpawn;

    public float decreaseTime;

    public float minTime = 0.65f;

    private void Update()
    {
        if (TimeBetweenSpawn <= 0)
        {
            int rand = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            TimeBetweenSpawn = StartTimeBetweenSpawn;
            if (StartTimeBetweenSpawn > minTime)
            {
                StartTimeBetweenSpawn -= decreaseTime;
            }
        }
        else 
        {
            TimeBetweenSpawn -= Time.deltaTime;
        }
    }   
}
