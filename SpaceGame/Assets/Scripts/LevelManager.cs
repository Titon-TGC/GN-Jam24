using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int score;
    public int hP;
    public int shP;
    public int maxHealth;
    public int newHealth;
    public GameObject playerPrefab;
    public Transform spawnPoint;
    public Transform position;
    public GameObject ship;
    private GameObject player;
    public GameObject playerStats;
    public GameObject endScreen;
    public Text scoreText;
    public Text endText;
    public Text hPText;
    public Text shPText;
    public Text scoreUI;
    public int deaths = 0;
    public bool lost;
    private int finalScore;

    void Start()
    {
        endScreen.SetActive(false);
        lost = false;
        player = GameObject.FindGameObjectWithTag("Player");
        position = GameObject.FindGameObjectWithTag("Player").transform;
        playerStats = GameObject.Find("PlayerStats");
        playerStats.GetComponent<PlayerStats>().LoadPlayer();
        ship = GameObject.FindGameObjectWithTag("Ship");
    }

    void Update()
    {
        hP = player.GetComponent<Health>().currentHealth;
        hPText.text = hP.ToString();

        shP = ship.GetComponent<Shiphealth>().currentHealth;
        shPText.text = shP.ToString();

        scoreUI.text = score.ToString();

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
        player.GetComponent<Health>().Revive();
        position = spawnPoint;
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

    public void Continue()
    {
        SceneManager.LoadScene("LevelMenu");
    }
}
