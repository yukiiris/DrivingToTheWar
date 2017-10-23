using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfNoteOn : MonoBehaviour {
	public GameObject note;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (note.activeInHierarchy) {
			transform.GetChild (0).gameObject.SetActive (false);
			GetComponent<C_Tutorial2> ().enabled = true;
			this.enabled = false;
		}
	}
}
