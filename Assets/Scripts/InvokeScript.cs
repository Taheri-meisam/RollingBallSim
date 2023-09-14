using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeScript : MonoBehaviour
{
    public GameObject target;

    void Start()
    {
        Invoke("SpawnObject", 2);
        //CancelInvoke();
    }

    void SpawnObject()
    {
        Instantiate(target, new Vector3(0, 0.5f, 0), Quaternion.identity);
    }
}
