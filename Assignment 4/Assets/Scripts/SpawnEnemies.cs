using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.Find("Enemy");
        spawnEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("spawnEnemies", 60, 5);
    }

    void spawnEnemies()
    {
        Instantiate(enemy);
        Instantiate(enemy);
        Instantiate(enemy);
        Instantiate(enemy);
        Instantiate(enemy);

    }
}
