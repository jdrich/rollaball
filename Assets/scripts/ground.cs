using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour {
    public void OnMouseDown()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.GetComponent<Collider>().isTrigger = true;
    }

    public void OnMouseUp()
    {
        gameObject.GetComponent<Renderer>().enabled = true;
        gameObject.GetComponent<Collider>().isTrigger = false;
    }

    public void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().enabled = true;
        gameObject.GetComponent<Collider>().isTrigger = false;
    }
}
