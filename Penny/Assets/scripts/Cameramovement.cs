using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramovement : MonoBehaviour {

	public GameObject penny;

	private float posIniy;

	private Penny pn;

	// Use this for initialization
	void Start () 
	{
		pn = penny.GetComponent<Penny> ();
		posIniy = transform.position.y-pn.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		float posx = pn.transform.position.x;
		float posy = pn.transform.position.y;
		transform.position = new Vector3 (posx, posy+posIniy, transform.position.z);
	}
}
