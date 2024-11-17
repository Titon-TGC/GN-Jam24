using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    public int upgradePoints;
    public GameObject PlayerStats;

    // Upgrade Buttons
    public Button upgrade1;
    public Button upgrade2;
    public Button upgrade3;
    public Button upgrade4;

    // Upgrade button text
    public Text upgrade1Text;
    public Text upgrade2Text;
    public Text upgrade3Text;
    public Text upgrade4Text;

    public Text cost1Text;
    public Text cost2Text;
    public Text cost3Text;
    public Text cost4Text;

    //Upgrade level
    public int currentUpgrade1;
    public int currentUpgrade2;
    public int currentUpgrade3;
    public int currentUpgrade4;

    // Upgrad cost
    public int upgrade1cost;
    public int upgrade2cost;
    public int upgrade3cost;
    public int upgrade4cost;

    // Upgrade addition amount
    public int upgrade1Level;
    public int upgrade2Level;
    public int upgrade3Level;
    public int upgrade4Level;

    public void Awake()
    {
        PlayerStats = GameObject.Find("PlayerStats");
        PlayerStats.GetComponent<PlayerStats>().LoadPlayer();
    }

    void Update()
    {
        upgradePoints = PlayerStats.GetComponent<PlayerStats>().upgradePoints;
        upgrade1Text.text = PlayerStats.GetComponent<PlayerStats>().currentUpgrade1.ToString();
        upgrade2Text.text = PlayerStats.GetComponent<PlayerStats>().currentUpgrade2.ToString();
        upgrade3Text.text = PlayerStats.GetComponent<PlayerStats>().currentUpgrade3.ToString();
        upgrade4Text.text = PlayerStats.GetComponent<PlayerStats>().currentUpgrade4.ToString();

        cost1Text.text = PlayerStats.GetComponent<PlayerStats>().upgrade1cost.ToString();
        cost2Text.text = PlayerStats.GetComponent<PlayerStats>().upgrade2cost.ToString();
        cost3Text.text = PlayerStats.GetComponent<PlayerStats>().upgrade3cost.ToString();
        cost4Text.text = PlayerStats.GetComponent<PlayerStats>().upgrade4cost.ToString();
    }

    public void Upgrade1()
    {
        if(upgradePoints >= upgrade1cost)
        {
            PlayerStats.GetComponent<PlayerStats>().RemovePoints(upgrade1cost);
            currentUpgrade1 += 1;
            upgrade1Level += 5;
            upgrade1cost += currentUpgrade1;
            PlayerStats.GetComponent<PlayerStats>().Upgrade1Set(upgrade1Level);
            PlayerStats.GetComponent<PlayerStats>().CurrUpgrade1();
            PlayerStats.GetComponent<PlayerStats>().Upgrade1Cost(upgrade1cost);
            PlayerStats.GetComponent<PlayerStats>().SavePlayer();
        }
    }

    public void Upgrade2()
    {
        if(upgradePoints >= upgrade2cost)
        {
            PlayerStats.GetComponent<PlayerStats>().RemovePoints(upgrade2cost);
            currentUpgrade2 += 1;
            upgrade2Level += 1;
            upgrade2cost += currentUpgrade2;
            PlayerStats.GetComponent<PlayerStats>().Upgrade2Set(upgrade2Level);
            PlayerStats.GetComponent<PlayerStats>().CurrUpgrade2();
            PlayerStats.GetComponent<PlayerStats>().Upgrade2Cost(upgrade2cost);
            PlayerStats.GetComponent<PlayerStats>().SavePlayer();
        }
    }

    public void Upgrade3()
    {
        if(upgradePoints >= upgrade3cost)
        {
            PlayerStats.GetComponent<PlayerStats>().RemovePoints(upgrade3cost);
            currentUpgrade3 += 1;
            upgrade3Level += 5;
            upgrade3cost += currentUpgrade3;
            PlayerStats.GetComponent<PlayerStats>().Upgrade3Set(upgrade3Level);
            PlayerStats.GetComponent<PlayerStats>().CurrUpgrade3();
            PlayerStats.GetComponent<PlayerStats>().Upgrade3Cost(upgrade3cost);
            PlayerStats.GetComponent<PlayerStats>().SavePlayer();
        }
    }

    public void Upgrade4()
    {
        if(upgradePoints >= upgrade4cost)
        {
            PlayerStats.GetComponent<PlayerStats>().RemovePoints(upgrade4cost);
            currentUpgrade4 += 1;
            upgrade4Level += 5;
            upgrade4cost += currentUpgrade4;
            PlayerStats.GetComponent<PlayerStats>().Upgrade4Set(upgrade4Level);
            PlayerStats.GetComponent<PlayerStats>().CurrUpgrade4();
            PlayerStats.GetComponent<PlayerStats>().Upgrade4Cost(upgrade4cost);
            PlayerStats.GetComponent<PlayerStats>().SavePlayer();
        }
    }
}
