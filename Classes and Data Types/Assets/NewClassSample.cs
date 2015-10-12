using UnityEngine;
using System.Collections;

public class NewClassSample : MonoBehaviour 
{

	public class Animals
	{
		public int rabbits;
		public int gerbils;
		public int hamsters;

		public Animals(int rab, int gerb, int ham)
		{
			rabbits = rab;
			gerbils = gerb;
			hamsters = ham;
		}


		public Animals()
		{
			rabbits = 3;
			gerbils = 2;
			hamsters = 4;
		}

	}

	Animals myAnimals = new Animals(10, 20, 30);




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
