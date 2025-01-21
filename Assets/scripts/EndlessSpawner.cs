using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // the prefab to spawn
    public Transform spawnPoint;   // the point where objects will be spammed

    float spawnInterval = 2f;  // time between spawns in seconds
    float minimumSpawnInterval = 1f; // the minimal amount of time between enemies spawning
    float intervalDecrease = 0.1f; // how much does the spawn time decrease by


    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {


        while (true)
        {
            if (objectToSpawn != null && spawnPoint != null)
            {
                Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
            }
            else 
            {
                Debug.LogWarning("Object to spawn or spawn point is not set");
        }

            // wait between spawn times
            yield return new WaitForSeconds(spawnInterval);

            //calculate the new spawn time
            spawnInterval = Mathf.Max(minimumSpawnInterval, spawnInterval - intervalDecrease);
        }
    }
}