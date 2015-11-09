using UnityEngine;
using System.Collections;

public class ArraysSample : MonoBehaviour {

	float[] myCollection = new float[4]; 
	float[] myOtherCollection = {3, 4, 7, 99, 5};
	public GameObject[] enemy;
	public GameObject[] player = new GameObject[2];

	// Use this for initialization
	void Start () {

		myCollection [0] = 45;
		myCollection [1] = 100;
		myCollection [2] = 33;
		myCollection [3] = 80;
		myOtherCollection [2] = 65;
	

		for (int i = 0; i < myCollection.Length; i++)
			Debug.Log (myCollection[i]);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
