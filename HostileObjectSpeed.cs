using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hostileobj : MonoBehaviour {

	public float speed = 4f;
	/*public static objmovement ref1;
	public static objmovement2 ref2;*/
	public GameObject cr;
	public GameObject sq;
	public float hostilePos;
	public static objmovement refobjforacc11;
	public int borrowscore;
	public int increment=0;
	public int scoremultiple;
	public int p = 2;
	// Use this for initialization
	void Start () {

		/*ref2=GameObject.FindGameObjectWithTag("circobj").GetComponent<objmovement2>();
		ref1=GameObject.FindGameObjectWithTag("squareobj").GetComponent<objmovement>();*/

	}

	// Update is called once per frame
	void Update () {

		refobjforacc11=GameObject.FindGameObjectWithTag("squareobj").GetComponent<objmovement>();
		borrowscore = refobjforacc11.totalscore1;
		if (borrowscore <= 7)
			speed = 4.2f;
		if (borrowscore > 7 && borrowscore < 14)
			speed = 5.1f;
		if (borrowscore >= 14 && borrowscore <= 21)
			speed = 5.75f;
		else if (borrowscore > 21 && borrowscore <= 30)
			speed = 6.5f;
		else if (borrowscore > 30 && borrowscore <= 40)
			speed = 7.25f;
		else if (borrowscore > 40 && borrowscore <= 50)
			speed = 8.0f;
		else if (borrowscore > 50 && borrowscore <= 60)
			speed = 8.5f;
		else if (borrowscore > 60 && borrowscore <= 65)
			speed = 8.75f;
		else if (borrowscore > 65 && borrowscore <= 70)
			speed = 9.0f;
		else if (borrowscore > 70 && borrowscore <= 78)
			speed = 9.25f;
		else if (borrowscore > 78 && borrowscore <= 86)
			speed = 9.5f;
		else if (borrowscore > 86 && borrowscore <= 95)
			speed = 9.75f;
		else if (borrowscore > 95 && borrowscore <= 105)
			speed = 10.0f;
		else if (borrowscore > 105 && borrowscore <= 115)
			speed = 10.5f;
		else if (borrowscore > 115 && borrowscore <= 130)
			speed = 11.0f;
		else if (borrowscore > 130 && borrowscore <= 140)
			speed = 11.5f;
		else if (borrowscore > 140 && borrowscore <= 150)
			speed = 12.0f;
		else if (borrowscore > 150 && borrowscore <= 160)
			speed = 12.5f;
		else if (borrowscore > 160 && borrowscore <= 170)
			speed = 13.0f;
		else if (borrowscore > 170 && borrowscore <= 180)
			speed = 13.5f;
		else if (borrowscore > 180 && borrowscore <= 200)
			speed = 13.75f;
		else if (borrowscore > 200)
			speed = 14.0f;


		hostilePos = gameObject.transform.position.y;
		transform.Translate (new Vector2 (0, -1) * speed * Time.deltaTime);
		if(gameObject.transform.position.y<-7f)
			Destroy (gameObject);

		if (gameObject.transform.position.y < -2.2f) { 


			Application.LoadLevel(2);
			if (refobjforacc11.totalscore1 > refobjforacc11.highestScore) {
				refobjforacc11.highestScore = refobjforacc11.totalscore1;
			}
			PlayerPrefs.SetInt ("currentScore", refobjforacc11.totalscore1);
			PlayerPrefs.SetInt ("highestScore", refobjforacc11.highestScore);
			PlayerPrefs.SetInt ("highestScoreOld", refobjforacc11.highestScoreOld);
			Debug.Log ("DESTROY GAMEOBJ");
		}

		}
			
	 
}
