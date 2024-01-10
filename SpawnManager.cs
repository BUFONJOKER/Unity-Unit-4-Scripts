using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerPrefab;
    private float spwnRange = 9;
    public int enemiesCount;
    public int enemyWaveNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnimies(enemyWaveNumber);
        Instantiate(powerPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        enemiesCount = FindObjectsOfType<Enemy>().Length;
        if (enemiesCount == 0)
        {
            enemyWaveNumber++;
            SpawnEnimies(enemyWaveNumber);
            Instantiate(powerPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);

        }
    }

    void SpawnEnimies(int totaleEnemies)
    {
        for (int i = 0; i < totaleEnemies; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);

        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spwnPostionX = Random.Range(-spwnRange, spwnRange);
        float spwnPostionZ = Random.Range(-spwnRange, spwnRange);
        Vector3 randomPosition = new Vector3(spwnPostionX, 0, spwnPostionZ);
        return randomPosition;
    }
}
