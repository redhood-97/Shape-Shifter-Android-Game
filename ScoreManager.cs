using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {


	public Text thisScoreObj;
	public Text thisHighScoreObj;
	// Use this for initialization
	void Start () {
		int score = PlayerPrefs.GetInt ("currentScore");
		int highScoreOld = PlayerPrefs.GetInt ("highestScoreOld");
		thisScoreObj.text = "" + score;
		if (score > highScoreOld) {
			thisHighScoreObj.text = "" + score;
		} else {
			thisHighScoreObj.text = "" + highScoreOld;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
