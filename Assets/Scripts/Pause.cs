using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Pause : MonoBehaviour
{
    public Text timeText;
    public Button resumeButton;
    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        //timeText.text = "Time: " + DateTime.Now.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
        if (isPaused)
        {
            timeText.text = "GAME PAUSED"; //+ DateTime.Now.ToString();
        }
    }
    void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
        timeText.text = "GAME PAUSED";
        resumeButton.gameObject.SetActive(true); //show resume button
        timeText.gameObject.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        //timeText.text = "Time: " + DateTime.Now.ToString();
        resumeButton.gameObject.SetActive(false); //hide resume button
        timeText.gameObject.SetActive(false);
    }
}
