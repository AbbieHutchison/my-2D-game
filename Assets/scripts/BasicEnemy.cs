using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicEnemy : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject player;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        player = GameObject.FindWithTag("Player");

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Invisibility.isInvisible == true)
        {
            agent.isStopped = true;
        }
        else 
        {
            agent.isStopped = false;
        }

        agent.SetDestination(player.transform.position);

        animator.SetFloat("VelocityX", agent.velocity.x);
        animator.SetFloat("VelocityY", agent.velocity.y);
    }
}
