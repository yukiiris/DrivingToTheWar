using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grain : MonoBehaviour {
	public Camera ca;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		StartCoroutine(rotate());
	}

	private IEnumerator rotate()
	{
		float i = ca.transform.eulerAngles.x > 180 ? ca.transform.eulerAngles.x - 360 : ca.transform.eulerAngles.x;
		while ((Mathf.Abs(i) > 0.1))
		{
			ca.transform.Rotate((Mathf.Abs(i) / i) * 0.1f, 0, 0);
			yield return 0.1f;
		}
	}
}
