using UnityEngine;
using System.Collections;

public class foreach_loop : MonoBehaviour {

	// Use this for initialization
	void Start () {


		string[] numCats = new string[3];

		numCats [0] = "This cat is black";
		numCats [1] = "This cat is white";
		numCats [2] = "This cat is calico";

		foreach (string indCat in numCats) 
		{
			Debug.Log (indCat);
		}







		/*
		foreach (string cat in numCats) 
		{
			print (cat);
		}*/

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
