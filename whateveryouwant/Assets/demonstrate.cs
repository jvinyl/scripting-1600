using UnityEngine;
using System.Collections;

public class demonstrate : MonoBehaviour {

	int thisInt = 22;

	// Use this for initialization
	void Start () {
	
		thisInt = MultiplyByThree (thisInt);

		Debug.Log(thisInt); 

	}

	int MultiplyByThree(int number) {
		
		int retValue;
		retValue = number * 3;
		return retValue;
		
	}

	// Update is called once per frame
	void Update () {
	
	}
}
