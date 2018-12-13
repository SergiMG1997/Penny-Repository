using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudmovement : MonoBehaviour {

	public float velocity;

	// Use this for initialization
	void Start () {
		//Debug.Log ("inici del moviment del nuvol");
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (velocity*Time.deltaTime, 0.0f, 0.0f);
	}
}
