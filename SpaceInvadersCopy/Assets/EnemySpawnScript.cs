using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    private float xSpawnPoint = 7.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, new Vector2(Random.Range(-xSpawnPoint, xSpawnPoint), transform.position.y), transform.rotation);
    }
}
