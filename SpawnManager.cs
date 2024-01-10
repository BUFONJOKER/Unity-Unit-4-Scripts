using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spwnRange = 9;
    // Start is called before the first frame update
    void Start()
    {
        
        Instantiate(enemyPrefab,GenerateSpawnPosition(),enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GenerateSpawnPosition(){
        float spwnPostionX= Random.Range(-spwnRange,spwnRange);
        float spwnPostionZ = Random.Range(-spwnRange,spwnRange);
        Vector3 randomPosition = new Vector3(spwnPostionX,0,spwnPostionZ);
        return randomPosition;
    }
}
