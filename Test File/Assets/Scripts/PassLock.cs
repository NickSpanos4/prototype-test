using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassLock : MonoBehaviour
{

    int passPlace;
    int passLength;

    public string pass = "";
    public string attemptedPass;

    public Transform openDoor;
    public GameObject textDisplay;
    public AudioSource errorSound;


    private void Start()
    {
        passLength = pass.Length;
    }
   

    //Checks if the attemped code is the same as the set code. If true, door opens for 4 seconds
    void CheckPass()
    {
        if (attemptedPass == pass)
        {
            StartCoroutine(Open());
        }

        else
        {
            Debug.Log("Incorrect Passcode");
        }
    }

    IEnumerator Open()
    {
        openDoor.Rotate(new Vector3(0, -90, 0), Space.World);

        yield return new WaitForSeconds(4);

        openDoor.Rotate(new Vector3(0, 90, 0), Space.World);
    }

    public void SetNumber(string num)
    {
        passPlace++;

        if (passPlace <= passLength)
        {
            attemptedPass += num;
            textDisplay.GetComponent<Text>().text = attemptedPass;
        }

        if (passPlace == passLength)
        {
            CheckPass();
            errorSound.Play();
            attemptedPass = "";
            passPlace = 0;
        }
    }
}
