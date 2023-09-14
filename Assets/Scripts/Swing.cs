using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Swing : MonoBehaviour
{
    public float swingSpeed = 30f;
    public float maxSwingAngle = 180f;
    private float currentAngle = 90f;
    private bool isSwingingLeft = true;
    [SerializeField] GameObject PivotPoint;

    void Start() 
    {
        transform.rotation = Quaternion.Euler(new Vector3(currentAngle, 90f, 90f));
    }
        
    void Update()
    {
        float swingAngleChange = swingSpeed * Time.deltaTime;
        if (isSwingingLeft)
        {
            currentAngle += swingAngleChange;
            if (currentAngle >= maxSwingAngle)
            {
                currentAngle = maxSwingAngle;
                isSwingingLeft = false;
            }
        }
        else
        {
            currentAngle -= swingAngleChange;
            if (currentAngle <= -maxSwingAngle)
            {
                currentAngle = -maxSwingAngle;
                isSwingingLeft = true;
            }
        }

        //transform.rotation = Quaternion.Euler(new Vector3(currentAngle,90f, 90f));
        transform.RotateAround(PivotPoint.transform.position,new Vector3(0f, 0f, 1f), currentAngle * Time.deltaTime);

    }
}
