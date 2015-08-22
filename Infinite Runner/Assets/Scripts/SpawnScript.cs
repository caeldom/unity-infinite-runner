﻿using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 2f;
	
	void Start () {
		Spawn();
	}
	
	void Spawn()
	{
		// spawn random obj from array
		Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity);
		Invoke("Spawn", Random.Range(spawnMin, spawnMax));
	}
}
