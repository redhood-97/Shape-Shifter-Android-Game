using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 //  this script is getting executed first//
public class objmovement2 : MonoBehaviour {

	/*public GameObject referenceobj;

	private objmovement otherscriptaccess;  // we dont actually need to access this variable from the inspector

    */
   
	/*public GameObject refobj1; */

	/**/
	public GameObject sq; 
	public GameObject cr;

	Vector3 restpossq = new Vector3 (-6f, -3f,1f);//rest position for square outside the frame
	Vector3 restposcr = new Vector3 (6f,-3f,1f); // rest position for circle outsidde the frame
	Vector3 p1 = new Vector3 (-1.5f, -2f,0f);//left position
	Vector3 p2 = new Vector3 (1.5f, -2f,0f);//right position
	Vector3 tempvar;
	// Use this for initialization
	public int t3;
	   // substitute for t1
	public int t4;
	   //substitute for t2

	public int score=0; 
	public int indicator2=0;
	public int totalscore2=0;

	public int p = 2;


	//public static GameObject hostile;

	public static objmovement refobjforacc;

	void Start () {

	
	//	hostile=GameObject.FindGameObjectWithTag("bluecircle").GetComponent<objmovement2>();
		refobjforacc=GameObject.FindGameObjectWithTag("squareobj").GetComponent<objmovement>();
		//t3 = Random.Range(0, 2);
		t3 = refobjforacc.t1;
		Debug.Log ("The value of t1 in objmovement2:");
		Debug.Log (t3);
		//t4 = Random .Range(0, 2);
		t4 = refobjforacc.t2;
		Debug.Log ("The value of t2 in objmovement2:");
		Debug.Log (t4);


		// JUST THE SPAWNING PART IS WORKING FINE//

		if (t3==0) 
		{   // the square object is supposed to be pushed outside the frame
			//Destroy (sq);

			sq.transform.position = restpossq;
			if (t4 == 0) 
			{   // if t2=0 then the object spawns at the left position
				cr.transform.position = p1;
				//indicator2=1;
				indicator2 = refobjforacc.indicator1;
			} 
			else if (t4 == 1) 
			{
				cr.transform.position = p2;
				//indicator2=1;
				indicator2 = refobjforacc.indicator1;
			}// if t2=1 then the object spawns at the right position
			Debug.Log ("Circular Object spawned");
			//ind = 1;

		} 
		else if(t3==1)
		{  // the circular object is supposed to be pushed outside frame
			//Destroy (cr);

			cr.transform.position = restposcr;
			if (t4 == 0) 
			{
				sq.transform.position = p1;
				//indicator2=0;
				indicator2 = refobjforacc.indicator1;
			}  // if t2=0 then the object spawns at the left position
			else if (t4 == 1) 
			{
				sq.transform.position = p2;
				//indicator2=0;
				indicator2 = refobjforacc.indicator1;
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

		// THE CODE FOR DIRECTION CONTROL STARTS HERE//

		

		Debug.Log ("The value of the indicator in objectmovement2:");
		Debug.Log (indicator2);

		// THE CODE FOR DIRECTION CONTROL ENDS HERE//

		// THE CODE FOR DIRECTION CONTROL STARTS HERE//


     }

	// THE CODE TILL THIS PART IS WORKING JUST FINE, IF ANY ERROR IS ENCOUNTERED, LOCATE FOR BUG BEYOND THIS PART//
	void OnCollisionEnter2D(Collision2D col)
	{
			if (col.gameObject.tag == "bluesquare" || col.gameObject.tag == "yellowsquare" || col.gameObject.tag == "pinksquare" || col.gameObject.tag == "greensquare") 
			{
				Destroy (cr);  // unlike objects collide to destruct

				gOvr ();
				Debug.Log ("GAME OVER !!");
			} 
			else if (col.gameObject.tag == "bluecircle" || col.gameObject.tag == "yellowcircle" || col.gameObject.tag == "pinkcircle" || col.gameObject.tag == "greencircle")
			{
			if (gameObject.transform.position.x >= -1.7f && gameObject.transform.position.x <= -1.3f)  // left position
				gameObject.transform.position = p1;
			else if (gameObject.transform.position.x >= 1.3f && gameObject.transform.position.x <= 1.7f) //right position
				gameObject.transform.position = p2;
			refobjforacc.totalscore1 += 1;     // like objects collide to increase points
			Debug.Log (refobjforacc.totalscore1);
				/*totalscore2 += 1;     // like objects collide to increase points
				Debug.Log (totalscore2);*/
				Destroy (col.gameObject);
			}
			

		/*	else if(col.gameObject.transform.position.x==-1.49f&&.transform.position.x==1.49f)
					Destroy(obj1);
				else if(col.gameObject.transform.position.x==1.49f&&obj1.transform.position.x==-1.49f)
					Destroy(obj1);
					*/

	}	


	public void Swap2()
	{

		if (sq.transform.position == restpossq) 
		{  // if the square is present outside the frame
			if (cr.transform.position == p1) 
			{ // if the circle is present in the left position
				//Debug.Log ("space pressed");
				cr.transform.position = restposcr;   // then put the circle outsidde the frame
				sq.transform.position = p1;  // and put the square in the left position
				//indicator2 = 0;  // when the square is inside the game scene
			//	indicator2 = refobjforacc.indicator1; //if the square object spawns
			} 
			else if (cr.transform.position == p2)
			{   // if the circle is in the frame and in the right position
				//Debug.Log ("space pressed");
				cr.transform.position = restposcr;   // then put the circle outside the frame
				sq.transform.position = p2;  // and put the square inside the frame and in the right position
				//indicator2 = 0;  // when the square is inside the game scene
			//	indicator2 = refobjforacc.indicator1; //if the square object spawns
			}

		} 
		else if (cr.transform.position == restposcr) 
		{ // now, we consider the case when the circle is outside the frame
			if (sq.transform.position == p1) 
			{  // if the square is inside the frame and is in the left position
				sq.transform.position = restpossq;    // put the square object outside the frame
				cr.transform.position = p1;   // then put the circular object insie the frame and in the left position.
				//indicator2 = 1;  // when the circle is inside the game scene
			//	indicator2 = refobjforacc.indicator1; //if the square object spawns
			} 
			else if (sq.transform.position == p2)
			{  // if the square is inside the frame and is in the right position
				sq.transform.position = restpossq;   // put the square object outside the frame
				cr.transform.position = p2;  // then, put the circular object inside the frame and in the right position
				//indicator2 = 1;  // when the circle is inside the game scene
			//	indicator2 = refobjforacc.indicator1; //if the square object spawns
			}

		}
	}

	public void move2(){
	
		//if (indicator2 == 0) 
		//{

			if (sq.transform.position == p2) // this part is working just fine
				sq.transform.position = p1;
			else if (sq.transform.position == p1)
				sq.transform.position = p2;
			

		//}
		//else if (indicator2 == 1) 
		//{

			if (cr.transform.position == p2) // this part is working just fine
				cr.transform.position = p1;
			else if (cr.transform.position == p1)
				cr.transform.position = p2;
		//}

		// THE CODE FOR DIRECTION CONTROL ENDS HERE//

		/*if (indicator2 == 1) {//circle



		} */

	}
	void gOvr()
	{
		Application.LoadLevel (2);
		if (refobjforacc.totalscore1 > refobjforacc.highestScore) {
			refobjforacc.highestScore = refobjforacc.totalscore1;
		}
		PlayerPrefs.SetInt ("currentScore", refobjforacc.totalscore1);
		PlayerPrefs.SetInt ("highestScore", refobjforacc.highestScore);
		PlayerPrefs.SetInt ("highestScoreOld", refobjforacc.highestScoreOld);

	}


}

	 
