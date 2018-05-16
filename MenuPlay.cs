using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;


public class MenuPlay : MonoBehaviour {

	public bool IsConnectedToGoogleServices{ set; get;}

	// Use this for initialization
	void Start () {
		
		PlayGamesClientConfiguration config = new 
			PlayGamesClientConfiguration.Builder()
			.Build();

		// Enable debugging output (recommended)
		PlayGamesPlatform.DebugLogEnabled = true;

		// Initialize and activate the platform
		PlayGamesPlatform.InitializeInstance(config);
		PlayGamesPlatform.Activate();
		Social.localUser.Authenticate ((bool success) => {
			IsConnectedToGoogleServices = success;
		});
	}
	
	// Update is called once per frame
	void Update () {
		ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
		if (Physics.Raycast (ray, out hit, Mathf.Infinity))
		if (hit.transform.gameObject.name == "play")
		Application.LoadLevel(1);


		}


	public void Swapscene()
	{

		Application.LoadLevel (3);
	}


}
