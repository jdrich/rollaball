using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour {
    public float speed;
    public GameObject cameraObject;
    public Text scoreText;
    public int score;

    protected Rigidbody rigid;

	// Use this for initialization
	public void Start () {
        rigid = GetComponent<Rigidbody>();

        score = 0;

        updateScore(score);
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

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("pickup")) {
            Destroy(other.gameObject);

            score += 1;

            updateScore(score);
        }
    }

    protected void updateScore(int score)
    {
        scoreText.text = "SCORE: " + score;
    }

    protected Vector3 Movement {  get {
            return new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    } }
}
