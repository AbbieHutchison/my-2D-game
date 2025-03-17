using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TELEPORT : MonoBehaviour
{
    public Transform teleportLocation;

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.CompareTag("Player"))
        {
            otherCollider.transform.position = teleportLocation.position;
        }

    }
}

