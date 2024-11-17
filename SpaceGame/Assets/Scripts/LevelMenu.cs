using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMenu : MonoBehaviour
{
    public GameObject playerStats;

    private GameObject pStats;

    private void Awake()
    {
        if(GameObject.Find("PlayerStats(Clone)") == null)
        {
            if(playerStats != null)
            {
                pStats = Instantiate(playerStats);
            }
        }
    }
}
