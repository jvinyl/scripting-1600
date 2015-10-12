	using UnityEngine;
using System.Collections;

public class ClassSample : MonoBehaviour 
{
	public class Animals
	{
		public int lions;
		public int tigers;
		public int bears;

		public float ohMy;
	
		public Animals (int li, int ti, int be)
		{
			lions = li;
			tigers = ti;
			bears = be;
		}	

		public Animals (int li, float om)
		{
			lions = li;
			ohMy = om;
		}

		public Animals ()
		{
			lions = 1;
			tigers = 2;
			bears = 3;
		}
	}

	public Animals moreAnimals = new Animals (10, 20, 30);
	public Animals wordsAndAnimals = new Animals (5, 5.0f);




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
