using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlbumShowName : MonoBehaviour {
	private Text text;
	public GameObject album;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		text.text = album.GetComponent<AlbumController> ().ills [album.GetComponent<AlbumController> ().page].name;
	}
}
