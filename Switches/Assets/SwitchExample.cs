using UnityEngine;
using System.Collections;

public class SwitchExample : MonoBehaviour {

	public int response = 3;

	void Answer ()
	{
		switch (response) 
		{
		case 3:
			print ("Yes!");
			break;
		case 2:
			print ("Maybe...");
			break;
		case 1: 
			print ("...No...");
			break;
		default:
			print ("...I don't know!");
			break;
		}
	}
}
