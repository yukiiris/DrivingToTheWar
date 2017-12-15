using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grain : MonoBehaviour {
	public Camera ca;
	public GameObject game;
	bool isEnd = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isEnd)
		{
			game.SetActive(true);
			isEnd = false;
		}
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
			ca.transform.Rotate(0, -(Mathf.Abs(i) / i) * 0.1f, 0);
			i = ca.transform.eulerAngles.x > 180 ? ca.transform.eulerAngles.x - 360 : ca.transform.eulerAngles.x;
			yield return 0.1f;
		}
		isEnd = true;
	}
}
