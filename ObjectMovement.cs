using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objmovement : MonoBehaviour {



	/**/
	  public bool mybool = false;
	public int myint=3;
	public GameObject sq;
	public GameObject cr;

	Vector3 position,position1;
	Vector3 restpossq = new Vector3 (-6f, -3f,1f);//rest position for square outside the frame
	Vector3 restposcr = new Vector3 (6f, -3f,1f);//rest position for circle outside the frame
	Vector3 p1 = new Vector3 (-1.5f, -2f,0f);//left position
	Vector3 p2 = new Vector3 (1.5f, -2f,0f);//right position
	Vector3 tempvar;
	// Use this for initialization
	public int t1;
	public int t2;
	public int t5;
	public int t6;

	public int totalscore1=0;

	//public static objmovement2 refobjforacc;
	public int indicator1=0;
	public int p = 2;

	public int highestScore;
	public int highestScoreOld;

	void Start () {
		//refobjforacc=GameObject.FindGameObjectWithTag("circobj").GetComponent<objmovement2>();
		//t1 = refobjforacc.t3;

		if (PlayerPrefs.HasKey ("highestScore")) {
			highestScore = PlayerPrefs.GetInt ("highestScore");
			highestScoreOld = highestScore;
		} else {
			highestScore = 0;
			highestScoreOld = highestScore;
		}

		t1 = Random.Range(0, 2);
		Debug.Log ("t1 value for script objmovement=");
		Debug.Log (t1);
		//t2 = refobjforacc.t4;
		t2 = Random.Range(0, 2);
		Debug.Log ("t2 value for script objmovement=");
		Debug.Log (t2);


 

		if (t1==0) 
		{   // the square object is supposed to be pushed outside the frame
				//Destroy (sq);

			sq.transform.position = restpossq;
				if (t2 == 0)
			{   // if t2=0 then the object spawns at the left position
					cr.transform.position = p1;
				indicator1=1;
				//indicator1 = refobjforacc.indicator2;
				} 
			else if (t2== 1) 
			{
					cr.transform.position = p2;
				indicator1=1;
				 // indicator1 = refobjforacc.indicator2;
			}
			// if t2=1 then the object spawns at the right position
				Debug.Log ("Circular Object spawned");
				//ind = 1;
			} 
		else if(t1==1) 
		{  // the circular object is supposed to be pushed outside frame
				//Destroy (cr);

			cr.transform.position = restposcr;
				if (t2== 0)
			{
				sq.transform.position = p1;
				indicator1=0;
				//indicator1 = refobjforacc.indicator2;
				}  // if t2=0 then the object spawns at the left position
				else if (t2== 1) 
			{
				sq.transform.position = p2;
				indicator1=0;
				//indicator1 = refobjforacc.indicator2;
				} // if t2=1 then the object spawns at the right position
				Debug.Log ("Square Object spawned");
				//ind = 2;
			} 
	 

	}
	/* After start() fucntion is called, four combinations are possible:
	 * Square--->OUTSIDE    Circle--->LEFT
	 * Square--->OUTSIDE    Circle--->RIGHT
	 * Circle--->OUTSIDE    Square--->LEFT
	 * Circle--->OUTSIDE    Square--->RIGHT
	 */
	// Update is called once per frame
	
void Update () {

	/**/

		// THE CODE FOR SPAWNING BEGINS//



			// THE CODE FOR SPAWNING ENDS

		Debug.Log ("The value of the indicator in objectmovement2:");
		Debug.Log (indicator1);


		// THE CODE FOR DIRECTION CONTROL BEGINS//


	}
	// THE CODE TILL THIS PART IS WORKING JUST FINE, IF ANY ERROR IS ENCOUNTERED, LOCATE FOR BUG BEYOND THIS PART//
	void OnCollisionEnter2D(Collision2D col)
	{
		
		
			if (col.gameObject.tag == "bluecircle" || col.gameObject.tag == "yellowcircle" || col.gameObject.tag == "pinkcircle" || col.gameObject.tag == "greencircle")
			{
				Destroy (sq);// unlike objects collide to destruct

			gOvr ();
				Debug.Log ("GAME OVER !!");
			}
			else if (col.gameObject.tag == "bluesquare" || col.gameObject.tag == "yellowsquare" || col.gameObject.tag == "pinksquare" || col.gameObject.tag == "greensquare")
			{
			if (gameObject.transform.position.x >= -1.7f && gameObject.transform.position.x <= -1.3f)  // left position
				gameObject.transform.position = p1;
			else if (gameObject.transform.position.x >= 1.3f && gameObject.transform.position.x <= 1.7f)
				gameObject.transform.position = p2;
			totalscore1 += 1;     // like objects collide to increase points
			Debug.Log (totalscore1);
			/*	refobjforacc.totalscore2 += 1;     // like objects collide to increase points
			Debug.Log (refobjforacc.totalscore2);*/
				Destroy (col.gameObject);
			}



			/*	
			else if(col.gameObject.transform.position.x==-1.49f&&obj2.transform.position.x==1.49f)
					Destroy(obj2);
				else if(col.gameObject.transform.position.x==1.49f&&obj2.transform.position.x==-1.49f)
					Destroy(obj2);
					*/

	}	


	public void Swap(){
	
		if (sq.transform.position == restpossq)
		{  // if the square is present outside the frame
			if (cr.transform.position == p1)
			{ // if the circle is present in the left position
				Debug.Log ("space pressed");
				cr.transform.position = restposcr;   // then put the circle outsidde the frame
				sq.transform.position = p1;  // and put the square in the left position
				//indicator1 = refobjforacc.indicator2; //if the square object spawns
				//indicator1 = 0;
			} 
			else if (cr.transform.position == p2) 
			{   // if the circle is in the frame and in the right position
				Debug.Log ("space pressed");
				cr.transform.position = restposcr;   // then put the circle outside the frame
				sq.transform.position = p2;  // and put the square inside the frame and in the right position
				//indicator1 = refobjforacc.indicator2; //if the square object spawns
				//indicator1 = 0;
			}

		} 
		else if (cr.transform.position == restposcr) 
		{ // now, we consider the case when the circle is outside the frame
			if (sq.transform.position == p1) 
			{  // if the square is inside the frame and is in the left position
				sq.transform.position = restpossq;    // put the square object outside the frame
				cr.transform.position = p1;   // then put the circular object insie the frame and in the left position.
				//indicator1 = refobjforacc.indicator2; //if the square object spawns
				//indicator1 = 0;
			} 
			else if (sq.transform.position == p2) 
			{  // if the square is inside the frame and is in the right position
				sq.transform.position = restpossq;   // put the square object outside the frame
				cr.transform.position = p2;  // then, put the circular object inside the frame and in the right position
				//indicator1 = refobjforacc.indicator2; //if the square object spawns
				//indicator1 = 0;
			}

		}

	
	}

	public void move()
	{


		//if (indicator1 == 0) 
		//{

			if (sq.transform.position == p2) // this part is working just fine
				sq.transform.position = p1;
			else if (sq.transform.position == p1)
				sq.transform.position = p2;

		//}
		//else if (indicator1 == 1) 
		//{

			if (cr.transform.position == p2) // this part is working just fine
				cr.transform.position = p1;
			else if (cr.transform.position == p1)
				cr.transform.position = p2;

		//}

		// THE CODE FOR DIRECTION CONTROL ENDS HERE

	}
	void gOvr()
	{
		Application.LoadLevel (2);
		if (totalscore1 > highestScore) {
			highestScore = totalscore1;
		}
		PlayerPrefs.SetInt ("currentScore", totalscore1);
		PlayerPrefs.SetInt ("highestScore", highestScore);
		PlayerPrefs.SetInt ("highestScoreOld", highestScoreOld);

	}



}
