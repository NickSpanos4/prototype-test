using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class WinningTrigger : MonoBehaviour
{

    public float winTimer = 0;
    public GameObject winText;
    public AudioSource winSound;


    void Start()
    {
        winText.GetComponent<Text>().enabled = false;
    }

    void Update()
    {
        
        if (winTimer > 0)
        {
            winTimer -= Time.deltaTime;
            winText.GetComponent<Text>().enabled = true;
        }
        else if (winTimer < 0)
        {
            winTimer -= Time.deltaTime;
            SceneManager.LoadScene(0);
        }

    }



    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "GameController")
        {
            winTimer = 5;
            winSound.Play();
        }
    }
}
