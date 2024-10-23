using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Timer : MonoBehaviour
{
    [SerializeField]
    float timerValue = 30f;

    [SerializeField]
    TextMeshProUGUI timerText;

    void Start()
    {
        StartCoroutine(BeginTimer() );
    }

    IEnumerator BeginTimer()
    {
        while (timerValue >= 0)
        {
            timerValue -= Time.deltaTime;
            timerText.text = "Time:" + (int)timerValue;
            yield return null;
        }
        timerText.text = "Timer: 0";
    }
}