using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessSpawner : MonoBehaviour
{
    public List<Enemy> enemies = new List<Enemy>();
    public GameObject _enemyPrefab;

    public float minspawntime;
    public float maxspawntime;

    public float timeuntilspawn;

    void Awake()
    {
        settimeuntilspawn();
    }

    
    void FixedUpdate()
    {
        timeuntilspawn -= Time.deltaTime;

        if (timeuntilspawn <= 0)
        {
            Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
            settimeuntilspawn();
        }
    }

    void settimeuntilspawn()
    {
        timeuntilspawn = Random.Range(minspawntime, maxspawntime);
    }

[System.Serializable]
public class Enemy
{
    public GameObject enemyPrefab;
}
}
