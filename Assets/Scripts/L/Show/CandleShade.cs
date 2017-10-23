using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CandleShade : MonoBehaviour {
	private Animator ani;
	private ChangeAlpha ca;


	// Use this for initialization
	void Start () {
		ani = GetComponent<Animator> ();
		ca = transform.GetChild (0).GetComponent<ChangeAlpha> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (ani.GetBool ("ifOn")) {
			ca.changeAlpha ();
		}
	}
}
