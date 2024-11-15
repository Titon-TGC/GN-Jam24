using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int score;
    public GameObject playerPrefab;
    public Transform spawnPoint;
    public GameObject ship;
    public GameObject playerStats;
    public GameObject endScreen;
    public int deaths = 0;

    public void Respawn()
    {
        Invoke("RespawnPlayer", 5f);
        deaths += 1;
    }

    private void RespawnPlayer()
    {
        GameObject player = Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    public void AddPoints(int amount)
    {
        score += amount;
    }

    public void GameEnd()
    {

    }
}
