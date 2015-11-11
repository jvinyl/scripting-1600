using UnityEngine;
using System.Collections;

public class EnumDemonstrate : MonoBehaviour {

	enum Weekdays {Sunday, Monday, Tuesday};
	Weekdays myday1;
	// Use this for initialization
	void Start () {


		myday1 = Weekdays.Sunday;

		myday1 = nextDay (myday1);



	}

	Weekdays nextDay (Weekdays next)
	{
		if (next == Weekdays.Sunday)
			Weekdays = Weekdays.Monday;
		return next;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
