using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Camera Cam;
    public int damageAmount;
    private int up1;
    private int afterUpgrade;
    private GameObject PlayerStats;

    private void Awake()
    {
        Cam = Camera.main;
        PlayerStats = GameObject.Find("PlayerStats");
        up1 = PlayerStats.GetComponent<PlayerStats>().upgrade1Level;
        afterUpgrade = damageAmount + up1;
        damageAmount = afterUpgrade;
    }

    private void Update()
    {
        Offscreen();
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
         if (collision.gameObject.GetComponent<EnemyMovement>())
        {
            var healthController = collision.gameObject.GetComponent<Enemy_Health1>();
            healthController.DeltDamage(damageAmount);
        }
        Destroy(gameObject);
        
    }

    void Offscreen()
    {
        Vector2 screenPosition = Cam.WorldToScreenPoint(transform.position);

        if (screenPosition.x < 0 || screenPosition.x > Cam.pixelWidth || screenPosition.y < 0 || screenPosition.y > Cam.pixelHeight)
        {
            Destroy(gameObject);
        }
    }
}