using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Black : MonoBehaviour {

	public static bool isActive;
	public GameObject black;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		isActive = black.active;
	}

}
