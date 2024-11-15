using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehaviour : MonoBehaviour, ICollectableBehaviour
{
    public int amount;

    public void OnCollected(GameObject player)
    {
        player.GetComponent<Health>().Heal(amount);
    }
}
