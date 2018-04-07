using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FTScenesChange : MonoBehaviour {
	public GameObject controller;
	public int num = 0;
	private FTScenesChangeCon sc;

	void Start(){
		sc = controller.GetComponent<FTScenesChangeCon>();
	}

	void OnMouseDown(){
		switch (num) {
		case 0:
			sc.FtoF ();
			break;
		case 1:
			sc.FtoS ();
			break;
		case 2:
			sc.TbaF ();
			break;
		}
	}
}
