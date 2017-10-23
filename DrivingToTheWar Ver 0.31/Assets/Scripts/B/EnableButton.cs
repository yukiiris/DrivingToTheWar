using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableButton : MonoBehaviour {
	public GameObject book;
	public GameObject left;
	public GameObject right;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (book.active)
		{
			//left.SetActive(true);
			//right.SetActive(true);
		}
	}
}
