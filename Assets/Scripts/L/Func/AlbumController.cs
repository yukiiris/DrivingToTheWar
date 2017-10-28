using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlbumController : MonoBehaviour {
	public GameObject[] ills;
	public int page = 0;
	// Use this for initialization
	void Start () {
		ills = new GameObject[transform.childCount];
		for(int i = 0; i < transform.childCount; i++){
			ills [i] = transform.GetChild (i).gameObject;
		}
	}
	// Update is called once per frame
	void Update () {
		ills [page].SetActive (true);
	}
}
