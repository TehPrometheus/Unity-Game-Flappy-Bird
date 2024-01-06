using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrPipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRateInSeconds = 3f;
    private float accSeconds = 0;
    private float yOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        accSeconds += Time.deltaTime;

        if (accSeconds > spawnRateInSeconds)
        {
            SpawnPipe();
            accSeconds = 0; 
        }
    }

    void SpawnPipe()
    {
        float lowestY = transform.position.y - yOffset;
        float highestY = transform.position.y + yOffset;
        Vector3 position = new Vector3(transform.position.x, Random.Range(lowestY, highestY), 0);
        Instantiate(pipe, position, transform.rotation);
    }
}
