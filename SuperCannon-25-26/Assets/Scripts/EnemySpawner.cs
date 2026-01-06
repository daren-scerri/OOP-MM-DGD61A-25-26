using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{
    public List<EnemySO> enemyTypeList = new List<EnemySO>();
    public float enemySpawnInterval = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            int enemychoice = Random.Range(0, enemyTypeList.Count);
            float spawnPosX = Random.Range(GameData.XMin, GameData.XMax);
            Vector3 enemyPos = new Vector3(spawnPosX, GameData.YMax, 0);

            GameObject enemyInstance = Instantiate(enemyTypeList[enemychoice].enemyPrefab, enemyPos, Quaternion.identity);
            enemyInstance.GetComponent<Enemy>().health = enemyTypeList[enemychoice].health;
            enemyInstance.GetComponent<Enemy>().hitpoints = enemyTypeList[enemychoice].hitpoints;
            enemyInstance.GetComponent<Enemy>().speed = enemyTypeList[enemychoice].speed;


            yield return new WaitForSeconds(enemySpawnInterval);
        }


    }
}
