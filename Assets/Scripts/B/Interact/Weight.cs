using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour {
	Vector3 vector;
	private float x1, x2;
	private float y1, y2;
	public static bool isMouseUp = true;
	public int weight;
	public bool isChild = false;
	private GameObject parent;
	public bool isIn = false;
	// Use this for initialization
	void Start () {
		x1 = -4.55f;
		x2 = 1.9f;
		y1 = -1.64f;
		y2 = -2.09f;
		parent = gameObject.transform.parent.gameObject;
		vector = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		isMouseUp = false;
		gameObject.transform.SetParent(parent.transform);
	}


	private void OnMouseUp()
	{
		Vector3 v = gameObject.GetComponent<Transform>().position;
		//print(gameObject.transform.position.x);
		//print(gameObject.transform.position.y);
		if (isIn || (v.x > x1 && v.x < x2 && v.y < y1 && v.y > y2))
		{
	
		}
		else
		{
			gameObject.GetComponent<Transform>().position = vector;
		}
		isMouseUp = true;
	}

}
