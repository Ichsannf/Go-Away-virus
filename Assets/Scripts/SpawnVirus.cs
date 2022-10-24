using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVirus : MonoBehaviour
{
    public GameObject[] virus;
    public Transform[] spawnPoints;
    public float startSpawn;
    public float spawnInterval;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while(true)
        {
            int spawnPointIndex = Random.Range(0, spawnPoints.Length);
            GameObject virusObj = Instantiate(virus[Random.Range(0, virus.Length)], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
