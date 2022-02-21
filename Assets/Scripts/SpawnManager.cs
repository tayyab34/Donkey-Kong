using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private  float StartDelay=1;
    private float delay=5;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPosition", StartDelay, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Spawning Obstacles
    private void SpawnPosition()
    {
        int index = Random.Range(0, obstaclePrefab.Length);
        Instantiate(obstaclePrefab[index], transform.position, obstaclePrefab[index].transform.rotation);
    }
}
