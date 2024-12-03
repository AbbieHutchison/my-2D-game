using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisiondestroy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Only if we collided with the player
        if(collision.gameObject.CompareTag("Player"))
        {
            //Run this code
            Debug.Log("Collision detected with" + collision.gameObject.name);
            Destroy(gameObject);
        }
    }
}
