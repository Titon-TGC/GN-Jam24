using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    public float upgradePoints;
   
    public Button upgrade1;
    public Button upgrade2;

    public Text upgrade1Text;
    public Text upgrade2Text;

    public float currentUpgrade1;
    public float currentUpgrade2;

    public float upgrade1cost;

    public void GivePoints(float amount)
    {
        upgradePoints += amount;
    }

    void Update()
    {
        upgrade1Text.text = currentUpgrade1.ToString();
    }

    public void Upgrade1()
    {
        if(upgradePoints >= upgrade1cost)
        {
            upgradePoints -= upgrade1cost;
            currentUpgrade1 += 1f;
            upgrade1cost += currentUpgrade1;
        }
    }

    public void Upgrade2()
    {
        currentUpgrade2 += 1f;
    }
}
