using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static Timer instance;
    public TextMeshProUGUI timeCounter;

    private TimeSpan timePLaying;
    private bool timerON = false;
    private float currentTime;
    public static float finalTime;

    private void Awake() {
        instance = this;
    }

    private void Start() {
        timeCounter.text = "Time: 00:00.00";
    }
    
    public void StartTimer() {
        timerON = true;
        currentTime = 0f;

        StartCoroutine(UpdateTimer());
    }
    public void EndTimer() {
        timerON = false;
        finalTime = currentTime;
    }
    private IEnumerator UpdateTimer() {
        while (timerON) {
            currentTime += Time.deltaTime;
            timePLaying = TimeSpan.FromSeconds(currentTime/2);
            string timePlayerStr = "Time: " + timePLaying.ToString("mm':'ss'.'ff");
            timeCounter.text = timePlayerStr;

            yield return null;
        }
    }
}
