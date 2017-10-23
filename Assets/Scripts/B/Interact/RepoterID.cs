using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepoterID : MonoBehaviour {
	public GameObject reporterID;
	public GameObject game;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.GetChild(0).GetChild(0).gameObject.GetComponent<PuzzleManager>().ifPuzzleWin)
		{
			reporterID.SetActive(true);
			game.SetActive(false);
		}
		}

}
