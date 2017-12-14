using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour {

	public float x;
	float preX;

	// Use this for initialization
	void Start () {
		preX = transform.position.x;
		StartCoroutine(moveOut());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private IEnumerator moveOut()
	{
		while (Mathf.Abs(transform.position.x - x) > 0.1)
		{
			transform.position = new Vector3(transform.position.x - 0.3f, transform.position.y, transform.position.z);
			yield return 0.01f;
		}
	}

	private IEnumerator moveIn()
	{
		while (Mathf.Abs(transform.position.x - preX) > 0.1)
		{
			transform.position = new Vector3(transform.position.x + 0.3f, transform.position.y, transform.position.z);
			yield return 0.01f;
		}
	}
}
