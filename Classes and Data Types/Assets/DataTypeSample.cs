using UnityEngine;
using System.Collections;

public class DataTypeSample : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		Transform tran = Transform;
		tran = new Vector3 (3, 3, 3);

		Vector3 pos = transform.position;
		pos = new Vector3 (4, 4, 4);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
