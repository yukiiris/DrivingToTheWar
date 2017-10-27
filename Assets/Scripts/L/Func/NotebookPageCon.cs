using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookPageCon : MonoBehaviour {
	public GameObject notebook;
	public bool ifLast = true;
	private int i = -1;

	void Start () {
		if(!ifLast){
			i = 1;
		}	
	}

	void OnMouseDown () {
		if((EventButton.notePage>0&&ifLast)||(EventButton.notePage < (notebook.transform.childCount-1)&&(!ifLast))){
			notebook.GetComponent<NotebookController> ().pages [EventButton.notePage].SetActive (false);
			EventButton.notePage += i;
			notebook.GetComponent<NotebookController> ().pages [EventButton.notePage].SetActive (true);
		}
	}
}
