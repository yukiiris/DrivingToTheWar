using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skip : MonoBehaviour {
	public string CGname;
	public string toChange;



	void OnMouseDown(){
		SceneChanger.Change(CGname, toChange);
	}
}
