using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Invisibility : MonoBehaviour
{
   public Renderer rend;
   public static bool isInvisible = false;

    // Start is called before the first frame update
    void Start()
    {
        isInvisible = false;
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
        isInvisible = true;
    }

    void StopInvisible()
    {
        rend.GetComponent<Renderer>();
        rend.enabled = true;
        isInvisible = false;
    }
}
