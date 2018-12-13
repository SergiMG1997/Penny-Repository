using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public AudioClip ouch;
    public AudioClip coin;
    public AudioClip explosion;
    // Use this for initialization


    public void PlayOuch()
	{
		GetComponent<AudioSource>().clip = ouch;
		GetComponent<AudioSource>().Play();
	}
	
	public void PlayCoin()
	{
		GetComponent<AudioSource>().clip = coin;
		GetComponent<AudioSource>().Play();
	}

    public void PlayExplosion()
    {
        GetComponent<AudioSource>().clip = explosion;
        GetComponent<AudioSource>().Play();
    }
}
