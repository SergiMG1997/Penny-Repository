using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        GameManager.SoundStone();
        GameManager.ShakeCamera();
		GetComponent<Rigidbody2D> ().AddForce (new Vector2 (Random.Range(-200.0f, 50.0f), 500f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Platform") {			
			 Destroy (this.gameObject);
	    }
	}
}
