using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salt : MonoBehaviour {
	public float delay;
	public GameObject salt;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn", delay, delay);
	}
	// Update is called once per frame
	void Spawn () {
		Instantiate(salt, new Vector3(Random.Range(-2.5f, 2.5f), 10, 0), Quaternion.identity);
	}
}
