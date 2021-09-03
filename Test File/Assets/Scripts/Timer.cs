using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public float timer = 180;
    public float failTimer = 10;
    public Text timerText;
    public GameObject failText;


    void Start()
    {
        failText.GetComponent<Text>().enabled = false;
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else if (timer <= 0)
        {
            if (failTimer > 1)
            {
                failTimer -= Time.deltaTime;
                failText.GetComponent<Text>().enabled = true;
            }
            else
            {
                SceneManager.LoadScene(0);
            }
            
        }

        DisplayTimer(timer);
       
    }


    void DisplayTimer(float timerDisplay)
    {
        if (timerDisplay < 0)
        {
            timerDisplay = 0;
        }


        float minutes = Mathf.FloorToInt(timerDisplay / 60);
        float seconds = Mathf.FloorToInt(timerDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
