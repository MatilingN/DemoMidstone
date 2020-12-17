using System;
using System.Collections;
using UnityEngine;



public class Player : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;

	public HealthBar healthBar;
	public Animator playerAnimation;

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);

	
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.E))
		{
			TakeDamage(20);
		}
	}

	void OnTriggerStay2D(Collider2D col)
	{
		if (col.gameObject.tag == "Enemy")
		{
			TakeDamage(5);

		}

	}

	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);

		playerAnimation.SetTrigger("Hurt");

		if (currentHealth <= 0.0f)
		{
			playerAnimation.SetBool("Death", true);
			
		}
	}
}



