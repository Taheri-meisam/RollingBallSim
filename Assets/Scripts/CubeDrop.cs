using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDrop : MonoBehaviour
{
    [SerializeField] float timeToLive = 10;
    [SerializeField] float timeToDrop = 5.0f;
    MeshRenderer mr;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        mr.enabled = false;
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToDrop)
        {
           rb.useGravity=true;
           mr.enabled = true;
        }
        if(Time.time > timeToLive)
        {
           // rb.useGravity = false;
          //  mr.enabled = false;
        }
        
    }
}


// your task is to remove the cubes after a certain time 