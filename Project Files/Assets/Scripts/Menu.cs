using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;


public class Menu : MonoBehaviour
{
    public TextMeshProUGUI timeCounter;

    private TimeSpan LastTime;
    public static float finalTime;


    public void OnPlayButton () {
        SceneManager.LoadScene(1);
    }
    public void OnQuitButton () {
        //UnityEditor.EditorApplication.isPlaying = false;
    }

    public void Awake() {
        timeCounter.text = "Last Time: 00:00.00";

        LastTime = TimeSpan.FromSeconds(finalTime/2);

        string timePlayerStr = "Last Time: " + LastTime.ToString("mm':'ss'.'ff");
        timeCounter.text = timePlayerStr;
    }
}
