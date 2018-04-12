using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGManager : MonoBehaviour {
	public string CGname;
	public string toChange;
	public int time;
	// Use this for initialization
	void Start () {
		StartCoroutine(f());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator f()
	{
		yield return new WaitForSeconds(time);
		SceneChanger.Change(CGname, toChange);
	}
}
