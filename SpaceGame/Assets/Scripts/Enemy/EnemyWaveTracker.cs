using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaveTracker : MonoBehaviour
{
   // put this on enemy prefabs.
    void OnDestroy()
    {
        if (GameObject.FindGameObjectWithTag("WaveSpawner") != null)
        {
            GameObject.FindGameObjectWithTag("WaveSpawner").GetComponent<WaveSpawner>().spawnedEnemies.Remove(gameObject);
        }
     
    }
}
