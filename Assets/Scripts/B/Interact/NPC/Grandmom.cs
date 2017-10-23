using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grandmom : MonoBehaviour {
	public Dialog manager;
	// Use this for initialization
	void Start () {
		manager = GameObject.Find("DialogManager").GetComponent<Dialog>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		manager.show("asdsaf", new Vector3(400, 0, 0));
	}
}
