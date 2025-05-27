using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipePrefab;


    // Start is called before the first frame update
    
    void SpawnPipes()
    {
        Instantiate(pipePrefab, new Vector2(8, Random.Range(-4.27f, 0.58f)), Quaternion.identity);
    }
    
    void Start()
    {
        InvokeRepeating("SpawnPipes", 1.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
