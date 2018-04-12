using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedRightAct : MonoBehaviour {
	public GameObject toUnload1;
	public GameObject toUnload2;
	public GameObject toUnload3;
	public GameObject coldrex;
	public GameObject pesticide;
	public 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ColdrexRight(){
		toUnload1.SetActive (false);
		toUnload2.SetActive (false);
		toUnload3.SetActive (false);
	}
}
