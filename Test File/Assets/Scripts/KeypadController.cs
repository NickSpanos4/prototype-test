using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadController : MonoBehaviour
{

    PassLock pass;

    int rayRange = 100;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CheckButtonHit();
        }
    }

    //Uses rayvasting to check the objects being hit, in this case the numbered buttons.
    void CheckButtonHit()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, rayRange))
        {
            pass = hit.transform.gameObject.GetComponentInParent<PassLock>();

            if (pass != null)
            {
                string num = hit.transform.name;
                pass.SetNumber(num);
            }
        }
    }
}
