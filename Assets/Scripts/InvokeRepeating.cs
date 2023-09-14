using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeRepeating : MonoBehaviour
{
    public GameObject target;
    public GameObject Player;

    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 5);
    }

    void SpawnObject()
    {
        //float x = Random.Range(-7.0f, 7.0f);
        //float z = Random.Range(1.0f, 100.0f);
        float x = Random.Range(-7.0f, 7.0f);
        float z = Random.Range(Player.transform.position.z + 10, Player.transform.position.z +30.0f);
        Instantiate(target, new Vector3(x, 2, z), Quaternion.identity);
    }
}
