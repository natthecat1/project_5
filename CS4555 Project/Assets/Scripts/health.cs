using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public float maxHealth = 100;
    [SerializeField] public float currentHealth;

    public HealthBar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void GetHealth(float hp)
    {
        currentHealth += hp;
        healthBar.SetHealth(currentHealth);
    }
}
