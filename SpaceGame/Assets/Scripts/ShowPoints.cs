using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPoints : MonoBehaviour
{
    private GameObject PlayerStats;
    public Text text;
    
    void Awake()
    {
        PlayerStats = GameObject.Find("PlayerStats");
    }

    void Update()
    {
        text.text = PlayerStats.GetComponent<PlayerStats>().upgradePoints.ToString();
    }
}
