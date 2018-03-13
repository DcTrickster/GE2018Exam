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
		for (int i = 0; i < 1; i++) 
		{
	
			Instantiate (eaglePrefab, new Vector3 (i, 0, i * gap), Quaternion.identity);
			SpawnFollowers ();
		}

	}

	public void SpawnFollowers()
	{
		for (int i = 0; i < 4; i++) 
		{
			Instantiate (eagleFollowerPrefab, new Vector3 (1 * gap, 0, i * gap), Quaternion.identity);
		}
	}

}
