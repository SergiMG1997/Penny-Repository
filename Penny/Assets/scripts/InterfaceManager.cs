using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceManager : MonoBehaviour {

	public void PlayGame()
	{
		SceneManager.LoadScene ("scene1");
	}

	public void QuitGame()
	{
		Application.Quit ();
	}

	void Update()
	{
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

    public void PlayMenu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
