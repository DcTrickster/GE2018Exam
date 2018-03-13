using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boid : MonoBehaviour 
{

	public Vector3 force;
	public Vector3 accelleration;
	public Vector3 velocity;
	public float mass = 1f;
	public float maxSpeed = 10f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
//		force = Calculate ();
		Vector3 newAcceleration = mass / force;
		Vector3 smoothRate = new Vector3 (4f * Time.deltaTime,0.15f,0.4f)/2f;
		Vector3 distance = Mathf.Lerp (accelleration,newAcceleration,smoothRate);

	}

//	public Vector3 Calculate()
//	{
//		force = Vector3.zero;
//	}

	public Vector3 Seek(Vector3 target)
	{
		
	}
}
