using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrainController : MonoBehaviour {

	public Bug[] bugs;
	public bool ifStart = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ifStart)
		{
			StartCoroutine(f());
			ifStart = false;
		}
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
