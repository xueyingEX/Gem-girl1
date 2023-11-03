using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{
    public GameObject cherryPrefab;
    private float spawnInterval = 10.0f;
    private float nextSpawnTime;

    private void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            SpawnCherry();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    void SpawnCherry()
    {
        Vector2 spawnPosition = Camera.main.ViewportToWorldPoint(new Vector2(Random.Range(0f, 1f), -0.1f));

        GameObject cherry = Instantiate(cherryPrefab, spawnPosition, Quaternion.identity);

        cherry.GetComponent<CherryMovement>().SetDirection(Vector2.up);
    }
}