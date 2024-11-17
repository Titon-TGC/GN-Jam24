using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack : MonoBehaviour
{
    public int damageAmount;
    private float attackHeat;
    private const float timeBetweenAttacks = 0.5f;

    void Update()
    {
        if (attackHeat > 0)
        {
            attackHeat -= Time.deltaTime;
        }

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Playermovement>() && attackHeat <= 0)
        {
            var healthController = collision.gameObject.GetComponent<Health>();
            healthController.TakeDamage(damageAmount);
            attackHeat = timeBetweenAttacks;
        }
        if (collision.gameObject.GetComponent<Shiphealth>() && attackHeat <= 0)
        {
            var healthController = collision.gameObject.GetComponent<Shiphealth>();
            healthController.ShipDamage(damageAmount);
            attackHeat = timeBetweenAttacks;
        }
    }
}
