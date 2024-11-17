using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    //Upgrades
    public int upgrade1Level;
    public int upgrade2Level;
    public int upgrade3Level;
    public int upgrade4Level;

    public int upgradePoints;

    public int currentUpgrade1;
    public int currentUpgrade2;
    public int currentUpgrade3;
    public int currentUpgrade4;

    public int upgrade1cost;
    public int upgrade2cost;
    public int upgrade3cost;
    public int upgrade4cost;

    public PlayerData (PlayerStats player)
    {
        upgrade1Level = player.upgrade1Level;
        upgrade2Level = player.upgrade2Level;
        upgrade3Level = player.upgrade3Level;
        upgrade4Level = player.upgrade4Level;

        upgradePoints = player.upgradePoints;

        currentUpgrade1 = player.currentUpgrade1;
        currentUpgrade2 = player.currentUpgrade2;
        currentUpgrade3 = player.currentUpgrade3;
        currentUpgrade4 = player.currentUpgrade4;

        upgrade1cost = player.upgrade1cost;
        upgrade2cost = player.upgrade2cost;
        upgrade3cost = player.upgrade3cost;
        upgrade4cost = player.upgrade4cost;
    }
}
