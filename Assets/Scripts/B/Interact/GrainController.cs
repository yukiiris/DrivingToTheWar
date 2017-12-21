using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrainController : MonoBehaviour {

	public Bug[] bugs;
	// Use this for initialization
	void Start () {
		f();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void f()
	{
		//int n = Random.Range(0, 9);
		bugs[1].move = true;
	}
}
