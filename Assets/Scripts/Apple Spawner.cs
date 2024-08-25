using System;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class EnemySpawnController : MonoBehaviour
{

    [SerializeField]
    private GameObject enemyPrefab; // acts as a template

    [SerializeField]
    private float numEnemiesVelocity = 0.05f; // velocity of increasing number of enemies

    [SerializeField]
    private float generateEnemyInterval = 2;

    private float numEnemies = 1;

    private float polledTime;

    // the starting position of the enemy
    private const float START_Y = 5f;

    // horizontal limits of the enemy
    private const float MAX_X = 8f;
    private const float MIN_X = -MAX_X;

    void Start()
    {
        GenerateEnemy();
    }

    void Update()
    {
       //numEnemies += numEnemiesVelocity * Time.deltaTime;

        polledTime += Time.deltaTime;
        if (polledTime >= generateEnemyInterval)
        {
            // time to generate enemy
            int numGenEnemy = (int)numEnemies;
            for (int i = 0; i < numGenEnemy; ++i)
            {
                GenerateEnemy();
            }

            polledTime = 0;
        }
    }

    private const float MIN_VELOCITY = -0.05f;
    private const float MAX_VELOCITY = -0.6f;

    private void GenerateEnemy()
    {
        float randomX = UnityEngine.Random.Range(MIN_X, MAX_X);
        Vector3 position = new Vector3(randomX, START_Y, 0);
        GameObject enemyObject = (GameObject)Instantiate(enemyPrefab, position, Quaternion.identity);
        Enemy enemy = enemyObject.GetComponent<Enemy>();

        // generate and set a random velocity
        float randomVelocity = UnityEngine.Random.Range(MIN_VELOCITY, MAX_VELOCITY);
        enemy.SetVelocity(new Vector3(0, randomVelocity, 0));
    }

}
