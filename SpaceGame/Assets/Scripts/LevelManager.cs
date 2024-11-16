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
    private bool lost;
    private int finalScore;

    public int shipHP;
    public int hP;

    public Text scoreUI;
    public Text shipHPText;
    public Text hPText;

    private GameObject player;

    void Start()
    {
        endScreen.SetActive(false);
        lost = false;
    }

    private void RespawnPlayer()
    {
        GameObject player = Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    void Update()
    {
        shipHP = ship.GetComponent<Shiphealth>().currentHealth;
        shipHPText.text = shipHP.ToString();

        player = GameObject.FindGameObjectWithTag("Player");

        hP = player.GetComponent<Health>().currentHealth;
        hPText.text = hP.ToString();

        scoreUI.text = score.ToString();

        if(ship.GetComponent<Shiphealth>().currentHealth <= 0)
        {
            lost = true;
            GameEnd();
        }

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
        Time.timeScale = 0f;
        scoreText.text = finalScore.ToString();
    }

    public void Leave()
    {
        SceneManager.LoadScene("LevelMenu");
    }
}
