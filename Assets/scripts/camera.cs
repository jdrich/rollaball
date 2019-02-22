using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject player;
    public float rotationSpeed;

	// Use this for initialization
	public void Start () {
    }
	
	// Update is called once per frame
	public void LateUpdate() 
    {
        if (Input.GetKey(KeyCode.E))
        {
            transform.RotateAround(player.transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.RotateAround(player.transform.position, Vector3.up, -rotationSpeed * Time.deltaTime);
        }
    }
}
