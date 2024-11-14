using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Camera Cam;

    private void Awake()
    {
        Cam = Camera.main;
    }

    private void Update()
    {
        Offscreen();
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        
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