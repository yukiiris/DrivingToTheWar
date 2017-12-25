using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrainController : MonoBehaviour {

	public Bug[] bugs;
	// Use this for initialization
	void Start () {
		StartCoroutine(f());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private IEnumerator f()
	{
		while (true)
		{
			int n = Random.Range(0, 9);
			bugs[n].move = true;
			yield return new WaitForSeconds(2f);
		}
	}
}
