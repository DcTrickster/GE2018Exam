using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour 
{

	public GameObject leader;

	private Vector3 offset;

	// Use this for initialization
	void Start () 
	{
		leader = GameObject.FindGameObjectWithTag ("Leader");
		offset = transform.position - leader.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = leader.transform.position + offset;

	}
}
