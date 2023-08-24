using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //array for animals to spawn
    public GameObject[] animalPrefabs;
    //variable for spawn positions
    private float spawnRangeX = 12;
    private float spawnPosZ = 20;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;



    // Start is called before the first frame update
    void Start()
    {
        //use invoke repeating to repeat method after an certain amount of time
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {


    }

    void SpawnRandomAnimal()
    {
        //get random numbers from random.range
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        //get random number for spawnPosition 
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        //instanciate animals with animal prefab and animal index
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
