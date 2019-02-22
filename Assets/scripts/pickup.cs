using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour {
    public float rotationSpeed;

	// Use this for initialization
	void Start () {
        this.tag = "pickup";		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(rotationSpeed, rotationSpeed, rotationSpeed) * Time.deltaTime);
	}
}
