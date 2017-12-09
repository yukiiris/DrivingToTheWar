using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour {
	Vector3 vector;
	public float x1, x2;
	public float y1, y2;
	public static bool isMouseUp = true;
	public int weight;
	public bool isChild = false;
	private GameObject parent;
	// Use this for initialization
	void Start () {
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
		if (v.x > x1 || v.x < x2 || v.y > y1 || v.y < y2)
		{
			//gameObject.GetComponent<Transform>().position = vector;
		}
		isMouseUp = true;
	}

}
