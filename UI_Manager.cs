using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {
	public Text scoreText;
	public static objmovement refobjforsc;

	// Use this for initialization
	void Start () {

		refobjforsc=GameObject.FindGameObjectWithTag("squareobj").GetComponent<objmovement>();
		
	}
	
	// Update is called once per frame
	void Update () {

		scoreText.text = ""+refobjforsc.totalscore1;
		
	}

	/*public void Play()
	{
		SceneManager.LoadScene("sceneobjswap",LoadSceneMode.Additive);
	}
	*/
}
