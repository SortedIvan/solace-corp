using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyTimer : MonoBehaviour
{
    public float timeRemaining = 25;
    public bool timerIsRunning = false;
    private void Start()
    {
        
    }

    private void StartTimer()
    {
        timerIsRunning = true;
    }

    private void StopTimer()
    {
        timerIsRunning = false;
    }
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }
}
