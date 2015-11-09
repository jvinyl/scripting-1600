using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour {

	float[] myCollection = new float [3];
	float[] myOtherCollection = {25, 50, 75, 100, 125};
	public GameObject[] player = new GameObject [4];
	public GameObject[] enemy;
	// Use this for initialization
	void Start () {
	
		player = GameObject.FindGameObjectsWithTag("Player");
		myCollection [0] = 10;
		myCollection [1] = 20;
		myCollection [2] = 30;
		myOtherCollection [4] = 99;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
