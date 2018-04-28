using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedRightAct : MonoBehaviour {
	public GameObject coldrex;
	public GameObject pesticide;
	private C_OneWords c1;
	private C_OneWords c2;
	private bool ifc = false;
	private bool ifp = false;

	// Use this for initialization
	void Start () {
		c1 = gameObject.GetComponents<C_OneWords> ()[0];
		c2 = gameObject.GetComponents<C_OneWords> ()[1];
	}
	
	// Update is called once per frame
	void Update () {
		if(EventButton.buttons[7]&&(!ifc)){
			transform.GetChild (0).gameObject.GetComponent<Restart> ().restart();
			ifc = true;
			ColdrexRight ();
		}
		if(EventButton.buttons[8]&&(!ifp)){
			ifp = true;
			PesticideRight ();
			GetComponent<Interact> ().enabled = false;
			GetComponent<Explore> ().enabled = true;
		}
	}

	void ColdrexRight(){
		coldrex.SetActive (true);
		unload ();
		c1.enabled = true;
	}

	void PesticideRight(){
		pesticide.SetActive (true);
		unload ();
		c2.enabled = true;
	}

	private void unload(){
		for (int i = 0; i < transform.childCount; i++) {
			transform.GetChild (i).gameObject.SetActive (false);
		}
	}
}
