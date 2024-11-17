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
    public Text scoreText;
    public Text endText;
    public int deaths = 0;
    public bool lost;
    private int finalScore;

    void Start()
    {
        endScreen.SetActive(false);
        lost = false;
        player = GameObject.FindGameObjectWithTag("Player");
        playerStats = GameObject.Find("PlayerStats");
        playerStats.GetComponent<PlayerStats>().LoadPlayer();
    }

    void Update()
    {
<<<<<<< Updated upstream:SpaceGame/Assets/LevelManager.cs
        if(ship.GetComponent<Shiphealth>().currentHealth <= 0)
        {
            lost = true;
            GameEnd();
        }
=======
        shipHP = ship.GetComponent<Shiphealth>().currentHealth;
        shipHPText.text = shipHP.ToString();

        hP = player.GetComponent<Health>().currentHealth;
        hPText.text = hP.ToString();

        scoreUI.text = score.ToString();
>>>>>>> Stashed changes:SpaceGame/Assets/Scripts/LevelManager.cs

        if(finalScore <= 0)
        {
            finalScore = 0;
        }
    }

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
        if(lost == true)
        {
            finalScore = score / 2;
            endText.text = "You lose!";
        }
        else
        {
            finalScore = score;
            endText.text = "You win!";
        }
        
        endScreen.SetActive(true);
        playerStats.GetComponent<PlayerStats>().AddToPoints(finalScore);
        playerStats.GetComponent<PlayerStats>().SavePlayer();
        Time.timeScale = 0f;
        scoreText.text = finalScore.ToString();
    }

    public void Leave()
    {
        SceneManager.LoadScene("LevelMenu");
    }
}
