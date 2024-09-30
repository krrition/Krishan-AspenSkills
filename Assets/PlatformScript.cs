using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{

    public GameObject Player,wp1,wp2;

    [SerializeField]
    private float Speed = 10;

    public bool flip = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == wp1.transform.position)
        {
            flip = false;
        }
        else if(transform.position == wp2.transform.position)

        {
            flip = true;
        }
        
        if (flip)
        {
            transform.position = Vector3.MoveTowards(transform.position, wp1.transform.position, Speed*Time.deltaTime);
        }
        else if (!flip)
        {
            transform.position = Vector3.MoveTowards(transform.position, wp2.transform.position, Speed*Time.deltaTime);
        }

        


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = transform;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = null;
        }
    }
}
