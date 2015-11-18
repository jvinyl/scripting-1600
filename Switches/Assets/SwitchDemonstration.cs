using UnityEngine;
using System.Collections;

public class SwitchDemonstration : MonoBehaviour 
{

	public int satellites = 3;

	void sky ()
	{
		switch (satellites) 
		{
		case 1:
			print ("Sun");
			break;

		case 2:
			print ("Moon");
			break;

		case 3:
			print ("Star");
			break;

		default:
			print ("None");
			break;
		}
	}

}
