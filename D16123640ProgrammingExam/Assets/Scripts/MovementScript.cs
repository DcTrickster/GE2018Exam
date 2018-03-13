using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {


	Rigidbody r;
	float speed = 10f;

	// Use this for initialization
	void Start () {
		r = GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.left * (speed * Time.deltaTime));
	}
}
