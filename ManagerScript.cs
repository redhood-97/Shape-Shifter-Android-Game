using UnityEngine.SocialPlatforms;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ManagerScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
		int Counter;
		int score = PlayerPrefs.GetInt ("currentScore");
		int highScoreOld = PlayerPrefs.GetInt ("highestScoreOld");
		if (score > highScoreOld)
			Counter = score;
		else
			Counter = highScoreOld;
		GooglePlayScript.AddScoreToLeaderboard (GPGSIds.leaderboard_leaderboard, Counter);*/
		
	}
	public void ShowLeaderboards()
	{
		GooglePlayScript.ShowLeaderboardsUI ();

	}
	
	// Update is called once per frame
}
