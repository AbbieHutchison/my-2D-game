using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossspawner : MonoBehaviour
{
   public GameObject enemy1;
    public Transform enemyspawn;
        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(enemy1, enemyspawn.position, Quaternion.identity);
        }
    }
}
