using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickups : MonoBehaviour {
    public int pickupCount;
    public GameObject prefab;
    public float radius;

	// Use this for initialization
	void Start ()
    {
        var counter = 0;

        while(counter < pickupCount) {
            var theta = counter * Mathf.PI * 2 / pickupCount;

            var pos = new Vector3(Mathf.Cos(theta), 0, Mathf.Sin(theta)) * radius;

            pos.y = prefab.transform.position.y;

            Instantiate(prefab, pos, Quaternion.identity);

            counter++;
        }
    }
}
