using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangramRotater : MonoBehaviour {

	public string s;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		transform.parent.transform.Rotate(new Vector3(0, 0, 90));
	}

	void rotateLeft()
	{
		transform.parent.transform.Rotate(new Vector3(90, 0, 0));
	}
}
