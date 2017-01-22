using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    //public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime;

	void Start () {

        InvokeRepeating("SpawnEnemy", spawnTime, spawnTime);

	}

    void SpawnEnemy() {

        /*
        if (playerHealth.currentValue <= 0) {
            return;
        } */
        //else {

        Instantiate(enemy, transform.position, transform.rotation);
        //}
    }
}
