using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallSpawnerScript : MonoBehaviour
{
    public GameObject wall;
    public float spawnRate = 2;
    private float spawnTime = 0;
    public float heightOffset = 5;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTime < spawnRate)
        {
            spawnTime = spawnTime + Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            spawnTime = 0;
        }
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(wall, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
