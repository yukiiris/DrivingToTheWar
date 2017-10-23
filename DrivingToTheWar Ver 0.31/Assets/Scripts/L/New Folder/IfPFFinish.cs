using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfPFFinish : MonoBehaviour {

	public GameObject block;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (EventButton.buttons [3]) {
			block.SetActive (false);
			Destroy (GetComponent<ChangeScene> ());
			GetComponent<Explore> ().enabled = true;
			GetComponent<C_ClearBlocks> ().enabled = true;
		}
	}
}
