using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonEffect : MonoBehaviour {
	public GameObject shade;
	// Use this for initialization
	void OnMouseEnter () {
		shade.SetActive (true);
	}

	void OnMouseExit(){
		shade.SetActive (false);
	}

}
