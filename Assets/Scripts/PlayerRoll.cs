using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class PlayerRoll : MonoBehaviour
{
    public float maxSpeed = 100.0f;
    public float minPitch = 0.5f;
    public float maxPitch = 2.0f;
    public float minVolume = 0.2f;
    public float maxVolume = 1.0f;
    public float moveSpeed = 10.0f;
    public float initSpeed = 10.0f;
    public float dashMultiplier = 2f;
    bool dashing;
    public GameObject gravitionalFoce;
    public float rpm;
    public float speed = 0;
    private Rigidbody rb;
    private AudioSource engineSound;
    // your task // finish this function
    public float getRPM()
    {
        return rpm;
    }


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        engineSound = GetComponent<AudioSource>();
        moveSpeed = initSpeed;
        dashing = false;
       // gravitionalFoce = GetComponent<GameObject>();    
    }

    void FixedUpdate()
    {
        speed = rb.velocity.magnitude;
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

        float pitch = Mathf.Lerp(minPitch, maxPitch, speed / maxSpeed* 2);
        float volume = Mathf.Lerp(minVolume, maxVolume, speed / maxSpeed *5);

        // Set pitch and volume for the engine sound
        engineSound.pitch = pitch;
        engineSound.volume = volume;
    }

}

// royalty free sounds 
//https://pixabay.com/sound-effects/search/engine/

