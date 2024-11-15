using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack : MonoBehaviour
{
    public int damageAmount;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Playermovement>())
        {
            var healthController = collision.gameObject.GetComponent<Health>();
            healthController.TakeDamage(damageAmount);
        }
        if (collision.gameObject.GetComponent<Shiphealth>())
        {
            var healthController = collision.gameObject.GetComponent<Shiphealth>();
            healthController.ShipDamage(damageAmount);
        }
    }
}
