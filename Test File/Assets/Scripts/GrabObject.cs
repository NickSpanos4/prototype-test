using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObject : MonoBehaviour
{

    public Transform theLocation;

    void OnMouseDown()
    {
      //attaches the object to a point in space in front of the FPSController
      //A blank gameObject titled Destination
      GetComponent<BoxCollider>().enabled = false;
      GetComponent<Rigidbody>().useGravity = false;
      this.transform.position = theLocation.position;
      this.transform.parent = GameObject.Find("Destination").transform;
    }

    void OnMouseUp()
    {
      this.transform.parent = null;
      GetComponent<BoxCollider>().enabled = true;
      GetComponent<Rigidbody>().useGravity = true;
    }

}
