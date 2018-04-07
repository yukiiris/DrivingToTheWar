using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FTScenesChangeCon : MonoBehaviour {
	//public GameObject camcon;

	public GameObject f;
	public GameObject t;
	public GameObject tfir;
	public GameObject tsec;

	private LongTimePress ltp;

	//private Vector3 rot = new Vector3 (0, 0, 0);

	void Start(){
		//ltp = camcon.GetComponent<LongTimePress> ();
	}

	public void FtoF(){
		//ltp.ifLongTimePress = true;
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		f.SetActive (false);
		t.SetActive (true);
		tfir.SetActive (true);
		tsec.SetActive (false);
	}

	public void FtoS(){
		//ltp.ifLongTimePress = true;
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		f.SetActive (false);
		t.SetActive (true);
		tfir.SetActive (false);
		tsec.SetActive (true);
	}

	public void TbaF(){
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		t.SetActive (false);
		f.SetActive (true);
	}
}
