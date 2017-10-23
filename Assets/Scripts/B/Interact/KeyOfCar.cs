using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyOfCar : MonoBehaviour {

	public GameObject key;
	public GameObject game;
	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		if (transform.GetChild(0).GetChild(5).GetComponent<PuzzleManager>().ifPuzzleWin)
		{
			key.SetActive(true);
			game.SetActive(false);
			GetComponent<C_OneWords> ().enabled = true;
		}
	}
}
