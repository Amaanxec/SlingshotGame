using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 60;
    public int currentHealth;
    

    public HealthBar healthbar;


    private void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetHealth(maxHealth);
      
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }

    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
    }
}
