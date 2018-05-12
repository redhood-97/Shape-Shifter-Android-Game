using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyobjspawn : MonoBehaviour {

	public GameObject obj1;
	public GameObject obj2;
	public GameObject obj3;
	public GameObject obj4;
	public GameObject obj5;
	public GameObject obj6;
	public GameObject obj7;
	public GameObject obj8;
	public float rightpos=1.5f;
	public float leftpos = -1.5f;
	float timer;
	public float delaytimer = 1f;

	// Use this for initialization

	void Start () {
		timer = delaytimer;
	}

	// Update is called once per frame
	
	void Update () {
		timer -= Time.deltaTime;
		if(timer<=0){
			Vector3 objpos;
			int maindynvar = Random.Range (0, 8);
			switch (maindynvar) {
			case 0:
				{
					int dynvar = Random.Range (0, 2); // because 2 is exclusive, only values we get are 0 and 1
					Debug.Log (dynvar);
					if (dynvar == 1)
						objpos = new Vector3 (1.49f, transform.position.y, transform.position.z);
					else
						objpos = new Vector3 (-1.49f, transform.position.y, transform.position.z);
					Instantiate (obj1, objpos, transform.rotation);
					break;
				}
			case 1:
				{
					int dynvar = Random.Range (0, 2); // because 2 is exclusive, only values we get are 0 and 1
					Debug.Log (dynvar);
					if (dynvar == 1)
						objpos = new Vector3 (1.49f, transform.position.y, transform.position.z);
					else
						objpos = new Vector3 (-1.49f, transform.position.y, transform.position.z);
					Instantiate (obj2, objpos, transform.rotation);
					break;
				}
			case 2:
				{
					int dynvar = Random.Range (0, 2); // because 2 is exclusive, only values we get are 0 and 1
					Debug.Log (dynvar);
					if (dynvar == 1)
						objpos = new Vector3 (1.49f, transform.position.y, transform.position.z);
					else
						objpos = new Vector3 (-1.49f, transform.position.y, transform.position.z);
					Instantiate (obj3, objpos, transform.rotation);
					break;
				}
			case 3:
				{
					int dynvar = Random.Range (0, 2); // because 2 is exclusive, only values we get are 0 and 1
					Debug.Log (dynvar);
					if (dynvar == 1)
						objpos = new Vector3 (1.49f, transform.position.y, transform.position.z);
					else
						objpos = new Vector3 (-1.49f, transform.position.y, transform.position.z);
					Instantiate (obj4, objpos, transform.rotation);
					break;
				}
			case 4:
				{
					int dynvar = Random.Range (0, 2); // because 2 is exclusive, only values we get are 0 and 1
					Debug.Log (dynvar);
					if (dynvar == 1)
						objpos = new Vector3 (1.49f, transform.position.y, transform.position.z);
					else
						objpos = new Vector3 (-1.49f, transform.position.y, transform.position.z);
					Instantiate (obj5, objpos, transform.rotation);
					break;
				}
			case 5:
				{
					int dynvar = Random.Range (0, 2); // because 2 is exclusive, only values we get are 0 and 1
					Debug.Log (dynvar);
					if (dynvar == 1)
						objpos = new Vector3 (1.49f, transform.position.y, transform.position.z);
					else
						objpos = new Vector3 (-1.49f, transform.position.y, transform.position.z);
					Instantiate (obj6, objpos, transform.rotation);
					break;
				}
			case 6:
				{
					int dynvar = Random.Range (0, 2); // because 2 is exclusive, only values we get are 0 and 1
					Debug.Log (dynvar);
					if (dynvar == 1)
						objpos = new Vector3 (1.49f, transform.position.y, transform.position.z);
					else
						objpos = new Vector3 (-1.49f, transform.position.y, transform.position.z);
					Instantiate (obj7, objpos, transform.rotation);
					break;
				}
			case 7:
				{
					int dynvar = Random.Range (0, 2); // because 2 is exclusive, only values we get are 0 and 1
					Debug.Log (dynvar); 
					if (dynvar == 1)
						objpos = new Vector3 (1.49f, transform.position.y, transform.position.z);
					else
						objpos = new Vector3 (-1.49f, transform.position.y, transform.position.z);
					Instantiate (obj8, objpos, transform.rotation);
					break;
				}

			}
			timer=delaytimer;   
		}
	}
}
