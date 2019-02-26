using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;   

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
        Vector3 current = transform.rotation * Vector3.up;
        Vector3 towards = player.GetComponent<player>().Velocity;

        current.y = 0;
        towards.y = 0;

        if(current.magnitude == 0 || towards.magnitude == 0) {
            return;
        }

        Vector3 cross = Vector3.Cross(current, towards);

        var direction = cross.y > 0 ? 1 : -1;

        var dotStuff = Vector3.Dot(towards, current) / (current.magnitude * towards.magnitude);

        // Fix floating point issue.
        if(dotStuff > 1) {
            dotStuff = 1;
        }
        
        if(dotStuff < -1) {
            dotStuff = -1;
        }

        var moveAngle = direction * Mathf.Acos(dotStuff);

        var moveDeg = moveAngle / Mathf.PI * 180; 

        transform.RotateAround(player.transform.position, Vector3.up, Mathf.LerpAngle(0, moveDeg, rotationSpeed * Time.deltaTime));        
    }
}
