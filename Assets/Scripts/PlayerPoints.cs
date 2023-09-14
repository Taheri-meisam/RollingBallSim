using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPoints : MonoBehaviour
{
    public int playerHP = 100;
    public int playerMaxMP = 100;
    public int hitNum = 0;
    [SerializeField] private Slider hpSlider;
    [SerializeField] private Camera camera;
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;
    [SerializeField] private Image sliderFill;
    [SerializeField] TMP_Text UIText;
    private void OnCollisionEnter(Collision collision)
    {
        hitNum++;
        if (collision.gameObject.tag == "wall" || collision.gameObject.tag =="drop")
        {
            playerHP--;
            sliderFill.color = Color.red;
            updateHealth(playerHP, playerMaxMP);
          
        }
      
        Debug.Log("Current health :" + playerHP);
    }
    private void OnCollisionExit(Collision collision)
    {
        sliderFill.color = Color.yellow;
    }
    private void updateHealth(float currentVal, float MaxVal)
    {
        hpSlider.value = currentVal / MaxVal;
        UIText.text = (hpSlider.value * 100).ToString() + "%";
    }
    private void Update()
    {
        hpSlider.transform.rotation = camera.transform.rotation;
        hpSlider.transform.position = target.position + offset;
    }
}
