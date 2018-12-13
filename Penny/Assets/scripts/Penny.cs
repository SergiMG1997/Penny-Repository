using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penny : MonoBehaviour {

    public int NumeroVides;
    public float forsa;
	public float velocity;
	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
        NumeroVides = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) { // Si el jugador toca la tecla D
			animator.SetInteger("state",1);
			GetComponent<SpriteRenderer> ().flipX = false;
			transform.Translate (velocity*Time.deltaTime, 0.0f, 0.0f);
		}

		if (Input.GetKey (KeyCode.A)) { // Si el jugador toca la tecla D
			animator.SetInteger ("state", 1);
			GetComponent<SpriteRenderer> ().flipX = true;
			transform.Translate (-velocity*Time.deltaTime, 0.0f, 0.0f);
		}

		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			animator.SetTrigger("jump");
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0f, forsa));
		}
			
		if (!Input.anyKey) {
			animator.SetInteger ("state", 0);
		}
    }

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Rock") {
			animator.SetTrigger ("hurt");
			Destroy (other.gameObject);
            NumeroVides = NumeroVides - 1;
            GameManager.DecrementaVida(NumeroVides);
			GameManager.ShakeCamera ();
		} else {
		   if (other.tag == "Coin")	{
			   GameManager.IncrementaCoins ();
		    }

            if (other.tag == "Bird")
            {
                animator.SetTrigger("hurt");
                NumeroVides = NumeroVides - 1;
                GameManager.DecrementaVida(NumeroVides);
            }
        }

	}
}
