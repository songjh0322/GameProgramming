using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float startTime = 1;
    public float endTime = 5;
    public float spawnRate = 0.5f;
    public float delay = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", startTime, spawnRate);
        Invoke("CancelInvoke", endTime);
        //Destroy(gameObject, delay);
    }


    void Spawn()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
