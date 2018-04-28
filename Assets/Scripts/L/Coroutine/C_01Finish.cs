using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_01Finish : MonoBehaviour {
	public LogManager manager;

	// Use this for initialization
	void Start () {
		manager = GameObject.Find("LogManager").GetComponent<LogManager>();
		StartCoroutine (OneFinish ());
	}

	IEnumerator OneFinish(){
		manager.show ("总算可以出发了，希望自己一路顺利。",2f);
		yield return new WaitForSecondsRealtime (2f);
		SceneChanger.Change("01","CG2");
		yield return null;
	}
}
