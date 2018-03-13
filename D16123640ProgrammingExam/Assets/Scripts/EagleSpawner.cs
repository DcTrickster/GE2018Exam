using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleSpawner : MonoBehaviour 
{

	public float gap = 20;
	public float followers = 2;
	public GameObject eaglePrefab;
	public GameObject eagleFollowerPrefab;



	// Use this for initialization
	void Awake () 
	{
		for (int i = 0; i < 5; i++) 
		{
	
			Instantiate (eaglePrefab, new Vector3 (this.transform.position.x, 0, i * gap), Quaternion.identity);

		}

	}

}
