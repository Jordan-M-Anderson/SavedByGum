using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public float spawnRate = 5;
    public GameObject spider;
    private float lastSpawn = 0f;

    private void Update()
    {
        lastSpawn += Time.deltaTime;

        if (lastSpawn > spawnRate) {

            lastSpawn = 0f;
            spawnSpider();

        }
    }

    void spawnSpider() {

        Instantiate(spider, transform.position, Quaternion.identity);

    }

}
