using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour

{
   public int damage = 5;
   
   private void OnTriggerEnter2D(Collider2D collision)
   {
        if (collision.CompareTag("Player"))
            return;
            
        if (collision.CompareTag("Enemy"))
        {
        collision.GetComponent<Health>()?.TakeDamage(damage);
        collision.GetComponent<bosshealth>()?.TakeDamage(damage);
        }

      Destroy(gameObject);
   }
}