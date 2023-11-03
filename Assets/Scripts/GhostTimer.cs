using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScareTimer : MonoBehaviour
{
    public Text timerText; // 
    private int countdownTime = 5; 
    private bool isScared = false;

    void Update()
    {
        if (isScared && countdownTime > 0)
        {
            countdownTime -= Mathf.FloorToInt(Time.deltaTime);
            timerText.text = countdownTime.ToString();

            if (countdownTime <= 0)
            {
                isScared = false;
                timerText.gameObject.SetActive(false);
            }
        }
    }

    public void TriggerScare()
    {
        isScared = true;
        timerText.gameObject.SetActive(true);
        countdownTime = 5; 
    }
}