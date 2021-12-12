using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class damagePlayer : MonoBehaviour
{
    public int playerHealth = 100;
    int damage = 20;


    void Start()
    {
        Debug.Log(playerHealth);
    }

    void OnCollisionEnter(Collision _collision)
    {
        if (_collision.gameObject.tag == "Enemy")
        {
            playerHealth = playerHealth - damage;
            Debug.Log("Your health is now " + playerHealth + " HP");
            if (playerHealth <= 0)
            {
                Debug.Log("GAME OVER");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
