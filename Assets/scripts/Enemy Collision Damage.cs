using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionDamage : MonoBehaviour
{
   public float damage;  // enemy damage

   private void OnCollisionEnter2D(Collision2D collision)
   {
    // if we collided with the player, grab the health script and deal damage
    if (collision.gameObject.CompareTag("Player"))
    {
        // the below line of code tries to find a health script on
        //the player object and deal damage if it finds one
        collision.gameObject.GetComponent<PlayerHealth>()?.TakeDamage(damage);
    } 
   }
}
