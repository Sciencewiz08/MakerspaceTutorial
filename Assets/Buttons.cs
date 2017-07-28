using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {
	public void Tutorial ()
	{
		SceneManager.LoadScene ("Tutorial");
	}

	public void Explore ()
	{

		SceneManager.LoadScene ("Menu");
	}
}
