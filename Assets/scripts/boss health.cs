using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bosshealth : MonoBehaviour
{
    public int maxHealth;  // we will use this to set the max health value in the inspector
    int currentHealth;     // hidden number to keep track of current health
    GameOverManager gom;


    private void Start()
    {
        currentHealth = maxHealth;   // we set the current health to whatever the max allowed health is 
        Debug.Log("Player health = " + currentHealth);
        gom = FindObjectOfType<GameOverManager>();
    }


   
    public void TakeDamage(int damage)  // we will use this function to change our health. it needs to be public so that other scripts can see it.
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()     // this function will mandate what happens when the enemy dies
    {
        Destroy(gameObject);
        gom.YouWin();
    }
}
