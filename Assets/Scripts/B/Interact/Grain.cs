using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grain : MonoBehaviour {
	public Camera ca;
	public GameObject game;
	bool isEnd = false;
	public GameObject con;
	public GrainController g;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isEnd)
		{
			game.SetActive(true);
			g.ifStart = true;
			isEnd = false;
		}
	}

	private void OnMouseDown()
	{
		//ca.transform.eulerAngles = new Vector3(0, 0, 0);
		StartCoroutine(rotate());
	}

	private IEnumerator rotate()
	{
		float i = ca.transform.eulerAngles.x > 180 ? ca.transform.eulerAngles.x - 360 : ca.transform.eulerAngles.x;
		float j = con.transform.eulerAngles.y > 180 ? con.transform.eulerAngles.y - 360 : con.transform.eulerAngles.y;

		while ((Mathf.Abs(i) > 0.1) || Mathf.Abs(j) > 0.1)
		{
			if (Mathf.Abs(i) > 0.1)
			{
				ca.transform.Rotate(-(Mathf.Abs(i) / i) * 0.1f, 0, 0);
				i = ca.transform.eulerAngles.x > 180 ? ca.transform.eulerAngles.x - 360 : ca.transform.eulerAngles.x;
			}
			if (Mathf.Abs(j) > 0.1)
			{
				con.transform.Rotate(0, (Mathf.Abs(i) / i) * 0.1f, 0);
				j = con.transform.eulerAngles.y > 180 ? con.transform.eulerAngles.y - 360 : con.transform.eulerAngles.y;
			}
			yield return new WaitForSeconds(0.001f);
		}
		isEnd = true;
	}
}
