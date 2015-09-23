using UnityEngine;
using System.Collections;

public class do_while_loop : MonoBehaviour {

	// Use this for initialization
	void Start () {

		bool somebool = false;
	
		do {
			Debug.Log ("This Value is True");
		} while (somebool == true);







		/*bool arbitraryBool = false;

		do
		{
			Debug.Log ("This arbitrary boolean is TRUE!");
		}while (arbitraryBool == true);*/
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
