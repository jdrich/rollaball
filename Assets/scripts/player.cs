using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    public float speed;
    public GameObject cameraObject;

    protected Rigidbody rigid;

	// Use this for initialization
	public void Start () {
        rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	public void Update () {
		
	}

    public void FixedUpdate()
    {
        var movement = cameraObject.transform.rotation * Movement;

        rigid.AddForce(movement * speed);

        if(Input.GetKey(KeyCode.Space)) {
            rigid.angularVelocity = Vector3.zero;
            rigid.velocity = Vector3.zero;
        }    
    }

    protected Vector3 Movement {  get {
            return new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    } }
}
