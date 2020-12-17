using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public int maxHealth = 100;
	int currentHealth;

	public Animator playerAnimation;



    // Start is called before the first frame update
    void Start()
	{
		currentHealth = maxHealth;

	}
	public void TakeDamage(int damage)
	{
		currentHealth -= damage;

		playerAnimation.SetTrigger("Hurt");

	if (currentHealth <= 0)
        {
			Die();
        }


	}

	void Die()
    {
		playerAnimation.SetBool("isDead", true);

		GetComponent<Collider2D>().enabled = false;
		this.enabled = false;


    }
}
