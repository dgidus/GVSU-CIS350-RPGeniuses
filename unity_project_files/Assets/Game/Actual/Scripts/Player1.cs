using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1 : MonoBehaviour
{
    public int maxHealth = 100;
	public int currentHealth;
    int damage = 20;

	public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter(Collision _collision)
    {
        if (_collision.gameObject.tag == "Enemy")
        {
            TakeDamage(20);
            Debug.Log("Your health is now " + currentHealth + " HP");
            if (currentHealth <= 0)
            {
                Debug.Log("GAME OVER");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }

    void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);


	}
}
