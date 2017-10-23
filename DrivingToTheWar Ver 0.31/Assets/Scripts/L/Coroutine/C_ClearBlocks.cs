using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_ClearBlocks : MonoBehaviour {
	public LogManager manager;
	// Use this for initialization
	void Start () {
		manager = GameObject.Find("LogManager").GetComponent<LogManager>();
		StartCoroutine (ClearBlocks ());
	}

	IEnumerator ClearBlocks(){
		manager.show ("整理好了，接下来可以去找主编拿战时通行证了。",2f);
		yield return null;

	}
}
