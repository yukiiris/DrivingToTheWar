using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossForObject : MonoBehaviour {

	public GameObject toUnload;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		toUnload.SetActive(false);
	}
}
