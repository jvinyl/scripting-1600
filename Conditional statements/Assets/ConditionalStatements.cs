using UnityEngine;
using System.Collections;

public class ConditionalStatements : MonoBehaviour {

	int someVal = 0;

	// Use this for initialization
	void Start () {
		if (someVal == 2) 
		{
			someVal++;
			Debug.Log (someVal);
		} 
		
		else if (someVal > 2) 
		{
			someVal = 0;
			Debug.Log (someVal);
		}
		
		else
		{
			someVal++;
			Debug.Log (someVal);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{

	}
}
