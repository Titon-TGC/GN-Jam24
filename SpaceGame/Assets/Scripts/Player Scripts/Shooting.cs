using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firepoint;
	public GameObject bulletPrefab;
	private GameObject pauseMenu;
	private GameObject pauseChild;
	private GameObject levelManager;
	private GameObject endScreen;
	public AudioSource audio;
	public AudioClip shoot;

	
	public float bulletForce = 20f;

	void Start()
	{
		audio = GetComponent<AudioSource>();
	}

    void Update()
    {
		pauseMenu = GameObject.Find("PauseMenu");
		pauseChild = pauseMenu.transform.Find("Pause Menu").gameObject;

		levelManager = GameObject.Find("LevelManager");
		endScreen = levelManager.transform.Find("EndScreen").gameObject;

        if(Input.GetButtonDown("Fire1") && pauseChild.activeSelf == false && endScreen.activeSelf == false)
		{
			Shoot();
		}
    }
	
	void Shoot()
	{
		audio.PlayOneShot(shoot);
		GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
		Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
		rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);
	}
}
