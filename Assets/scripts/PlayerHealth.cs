using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    float maxHealth;
    float currentHealth;

    public HUDManager HUD;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        HUD.UpdateHealthBar(currentHealth / maxHealth);
    }

   
    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;

        HUD.UpdateHealthBar(currentHealth/maxHealth);

        if (currentHealth <= 0)
        Die();
    }

    public void Die()
    {
        //this will get replaced with a death animation at somepoint
        Destroy(gameObject);
    }
}
