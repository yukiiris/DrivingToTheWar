using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseHerb : MonoBehaviour {
	public int num;
	// Use this for initialization

	void OnMouseDown(){
		HerbsList.herblist.Add (num);
		print (num);
		print (HerbsList.herblist.Count);
		gameObject.GetComponent<C_MoveToNotebook> ().enabled = true;
	}
}
