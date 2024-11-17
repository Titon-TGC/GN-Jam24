using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int upgradePoints;

    public int upgrade1Level;
    public int upgrade2Level;
    public int upgrade3Level;
    public int upgrade4Level;

    public int currentUpgrade1;
    public int currentUpgrade2;
    public int currentUpgrade3;
    public int currentUpgrade4;

    public int upgrade1cost;
    public int upgrade2cost;
    public int upgrade3cost;
    public int upgrade4cost;

    public void Awake()
    {
        LoadPlayer();
    }

    public void AddToPoints(int amount)
    {
        upgradePoints += amount;
    }

    public void RemovePoints(int amount)
    {
        upgradePoints -= amount;
    }

    public void Upgrade1Set(int amount)
    {
        upgrade1Level = amount;
    }
    
    public void Upgrade2Set(int amount)
    {
        upgrade2Level = amount;
    }

    public void Upgrade3Set(int amount)
    {
        upgrade3Level = amount;
    }

    public void Upgrade4Set(int amount)
    {
        upgrade4Level = amount;
    }

    public void CurrUpgrade1()
    {
        currentUpgrade1 += 1;
    }

    public void CurrUpgrade2()
    {
        currentUpgrade2 += 1;
    }

    public void CurrUpgrade3()
    {
        currentUpgrade3 += 1;
    }

    public void CurrUpgrade4()
    {
        currentUpgrade4 += 1;
    }

    public void Upgrade1Cost(int amount)
    {
        upgrade1cost = amount;
    }

    public void Upgrade2Cost(int amount)
    {
        upgrade2cost = amount;
    }

    public void Upgrade3Cost(int amount)
    {
        upgrade3cost = amount;
    }

    public void Upgrade4Cost(int amount)
    {
        upgrade4cost = amount;
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        upgradePoints = data.upgradePoints;
        upgrade1Level = data.upgrade1Level;
        upgrade2Level = data.upgrade2Level;
        upgrade3Level = data.upgrade3Level;
        upgrade4Level = data.upgrade4Level;

        currentUpgrade1 = data.currentUpgrade1;
        currentUpgrade2 = data.currentUpgrade2;
        currentUpgrade3 = data.currentUpgrade3;
        currentUpgrade4 = data.currentUpgrade4;

        upgrade1cost = data.upgrade1cost;
        upgrade2cost = data.upgrade2cost;
        upgrade3cost = data.upgrade3cost;
        upgrade4cost = data.upgrade4cost;
    }
}