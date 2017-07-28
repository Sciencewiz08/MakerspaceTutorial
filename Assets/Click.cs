using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{

	public void TaskOnClick()
	{
		
		Debug.Log("You have clicked the button!");
		SceneManager.LoadScene("Tutorial");
	}
}