using UnityEngine;
using System.Collections;

public class EnumSample : MonoBehaviour {

	enum Weekdays{Sunday = 1, Monday = 2, Tuesday = 3, Wednesday = 4, Thursday = 5, Friday = 6, Saturday = 7};

	// Use this for initialization
	void Start () 
	{
	
		Weekdays day1;
		day1 = Weekdays.Sunday;
	}

	Weekdays TwoDaysAfter (Weekdays twoAft)
	{
		if (twoAft == Weekdays.Sunday)
			twoAft = Weekdays.Tuesday;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
