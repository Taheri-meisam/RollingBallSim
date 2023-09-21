using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScript : MonoBehaviour
{
    Color orangeColor= new Color(1.0f, 0.64f, 0.0f);
    private AudioSource crashSound;

    private void Start()
    {
        crashSound = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collison happened " + this.name);
            GetComponent<MeshRenderer>().material.color = Color.red;
            crashSound.Play();
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        if (gameObject.tag == "drop")
        {
            GetComponent<MeshRenderer>().material.color = orangeColor;

        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
    

}
