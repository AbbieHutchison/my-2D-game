using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Invisibility : MonoBehaviour
{
   public Renderer rend;
   public GameObject enemy1;
   public GameObject enemy2;
   public GameObject enemy3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e"))
        {
            Invisible();
        }

        if(Input.GetKeyUp("e"))
        {
            StopInvisible();
        }
    }

    void Invisible()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
        enemy1.GetComponent<NavMeshAgent>().enabled = false;
        enemy2.GetComponent<NavMeshAgent>().enabled = false;
        enemy3.GetComponent<NavMeshAgent>().enabled = false;
    }

    void StopInvisible()
    {
        rend.GetComponent<Renderer>();
        rend.enabled = true;
        enemy1.GetComponent<NavMeshAgent>().enabled = true;
        enemy2.GetComponent<NavMeshAgent>().enabled = true;
        enemy3.GetComponent<NavMeshAgent>().enabled = true;
    }
}
