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


    private void Start()
    {
        passLength = pass.Length;
    }
   
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

            attemptedPass = "";
            passPlace = 0;
        }
    }
}
