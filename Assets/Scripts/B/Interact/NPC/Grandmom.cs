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
		manager.show("你好呀，年轻人", new Vector3(0, 0, 0));
	}
}
