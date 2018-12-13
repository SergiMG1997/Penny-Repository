using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneGenerator : MonoBehaviour {

	public GameObject rock;
	// Use this for initialization

	void Start () {
		InvokeRepeating ("CrearPedra", 0.0f, 2f);
	}

	void CrearPedra()
	{
		Instantiate (rock, transform.position, Quaternion.identity);
	}
	// Update is called once per frame

	void Update () {

	}
}
