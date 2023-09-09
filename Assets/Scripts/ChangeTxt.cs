using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTxt : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 300f;
    public Text countdownTxt;

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= Time.deltaTime;
        TimeSpan time = TimeSpan.FromMinutes(currentTime);
        countdownTxt.text = time.ToString("hh\\:mm");
        

        if (currentTime <= 0)
        {
            Debug.Log("acabou o tempo!");
            gameObject.SetActive(false);
        }
    }

}
