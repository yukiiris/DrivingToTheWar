using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlbumPageCon : MonoBehaviour {
	public GameObject album;
	public bool ifLast = true;
	private int i = -1;

	void Start () {
		if(!ifLast){
			i = 1;
		}	
		
	}

	void OnMouseDown () {
		if((album.GetComponent<AlbumController>().page>0&&ifLast)||(album.GetComponent<AlbumController>().page < (album.transform.childCount-1)&&(!ifLast))){
			album.GetComponent<AlbumController>().page += i;
			album.GetComponent<AlbumController> ().ills [album.GetComponent<AlbumController> ().page-i].SetActive (false);

		}
	}
}
