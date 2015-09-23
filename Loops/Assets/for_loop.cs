using UnityEngine;
using System.Collections;

public class for_loop : MonoBehaviour {

	//int startVal = 10;

	// Use this for initialization
	void Start () {

		int drawcards = 5;

		for (int i = 0; i <= drawcards; i++) 
		{
			Debug.Log ("You've drawn card number " + i);
		}


	
		/*for (int i = 0; i<= startVal; i++) 
		{
			Debug.Log ("Finger Number " + i);
		}*/

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
