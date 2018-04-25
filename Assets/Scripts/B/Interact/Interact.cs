using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour {

	public GameObject[] toLoad;
	public GameObject[] toUnload;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		for(int i = 0;i<toLoad.Length;i++){
			toLoad [i].SetActive (true);
		}

		for(int i = 0;i<toUnload.Length;i++){
			toUnload [i].SetActive (false);
		}
	}
}
