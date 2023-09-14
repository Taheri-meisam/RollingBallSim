using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class PlayerRoll : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float initSpeed = 10.0f;
    public float dashMultiplier = 2f;
    bool dashing;
    public GameObject gravitionalFoce;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveSpeed = initSpeed;
        dashing = false;
       // gravitionalFoce = GetComponent<GameObject>();    
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        if(Input.GetKey(KeyCode.Space) && !dashing)
        {
            moveSpeed = initSpeed  * dashMultiplier;
            dashing = true;
        }else
        {
            moveSpeed = initSpeed;
            dashing = false;
        }
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        rb.AddForce(movement * moveSpeed,ForceMode.Force);   ///  class tasks  try different forcemodes and expriement to learn more about forcemodes 

        // rb.AddForceAtPosition(rb.velocity, gravitionalFoce.transform.position);
    }

}
