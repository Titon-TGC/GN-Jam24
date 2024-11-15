using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firepoint;
	public GameObject bulletPrefab;
	private GameObject pauseMenu;
	
	public float bulletForce = 20f;

    void Update()
    {
		pauseMenu = GameObject.FindGameObjectWithTag("Pause Menu");

        if(Input.GetButtonDown("Fire1"))
		{
			Shoot();
		}
    }
	
	void Shoot()
	{
		
	GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
	Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
	rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);
	}
}
