using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGameobject : MonoBehaviour {

	void OnMouseDown(){
		gameObject.transform.parent.gameObject.SetActive (false);
	}
}
