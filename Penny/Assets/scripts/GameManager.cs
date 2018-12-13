using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {

    public static GameObject vida1;
    public static GameObject vida2;
    public static GameObject vida3;
	public static GameObject camera;
    public static GameObject CoinsCounterText;
	
	private static int CoinsCounter;
	
    public static GameObject gameover;
	
	public static GameObject soundManager;

    public void Start()
    {
        vida1 = GameObject.Find("CorVida1");
        vida2 = GameObject.Find("CorVida2");
        vida3 = GameObject.Find("CorVida3");

		camera = GameObject.Find("Main Camera");
        gameover = GameObject.Find("GameOver");
        gameover.SetActive(false);
		CoinsCounter = 0;
		CoinsCounterText = GameObject.Find ("CoinsCounter");
		soundManager = GameObject.Find ("SoundManager");
    }   
        
    public static void DecrementaVida(int numvides)
    {
        soundManager.GetComponent<SoundManager>().PlayOuch ();
		if (numvides == 2)
            vida3.SetActive (false);
        else if (numvides == 1)
            vida2.SetActive (false);
        else if (numvides == 0)
        {
            vida1.SetActive(false);
            gameover.SetActive(true);
        }
    } 
	
	public static void ShakeCamera ()
	{
		camera.GetComponent<CameraShake>().ShakeCamera();
	}
	
	public static void IncrementaCoins()
	{
		CoinsCounter = CoinsCounter + 1;
		CoinsCounterText.GetComponent<TextMeshProUGUI>().SetText(CoinsCounter.ToString());
		soundManager.GetComponent<SoundManager>().PlayCoin ();
	}

    public static void SoundStone()
    {
        soundManager.GetComponent<SoundManager>().PlayExplosion();
    }
}
