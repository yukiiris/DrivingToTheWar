using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour {

	public float x;
	float preX;
	bool isOut = false;

	// Use this for initialization
	void Start () {
		preX = transform.position.x;
		print(preX);
		StartCoroutine(moveOut());
	}
	
	// Update is called once per frame
	void Update () {
		if (isOut)
		{
			StopCoroutine(moveOut());
			StartCoroutine(moveIn());
			isOut = false;
		}
	}

	private IEnumerator moveOut()
	{
		while (Mathf.Abs(transform.position.x - x) > 1)
		{
			transform.position = new Vector3(transform.position.x - 0.3f, transform.position.y, transform.position.z);
			yield return 0.01f;
		}
		isOut = true;
	}

	private IEnumerator moveIn()
	{
		while (Mathf.Abs(transform.position.x - preX) > 1)
		{
			transform.position = new Vector3(transform.position.x + 0.3f, transform.position.y, transform.position.z);
			yield return 0.01f;
		}
	}
}
