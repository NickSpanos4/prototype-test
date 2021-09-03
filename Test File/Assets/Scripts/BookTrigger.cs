﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookTrigger : MonoBehaviour
{

    private int redBookCount = 0;
    private int blueBookCount = 0;
    private int greenBookCount = 0;
    public int redMaxCount;
    public int blueMaxCount;
    public int greenMaxCount;

    public GameObject Door;



    void Start()
    {
        Door = GetComponent<GameObject>();
    }

    void CheckBooks()
    {
        if ((redBookCount == redMaxCount))
        {
            Door.SetActive(false);
        }
    }


    //Checks if the book type when it enters the trigger based on the tag
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "redBook")
        {
            Debug.Log("Red Book Added");
           //Destroy(other.gameObject);
            redBookCount += 1;
            Debug.Log("Red Books:" + redBookCount);
        }
        if (other.gameObject.tag == "blueBook")
        {
            Debug.Log("Blue Book Added");
           // Destroy(other.gameObject);
            redBookCount += 1;
            Debug.Log("Blue Books:" + blueMaxCount);
        }
        if (other.gameObject.tag == "greenBook")
        {
            Debug.Log("Green Book Added");
            //Destroy(other.gameObject);
            greenBookCount += 1;
            Debug.Log("Green Books:" + greenBookCount);
        }
    }
}
