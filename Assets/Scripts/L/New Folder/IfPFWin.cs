using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IfPFWin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<PuzzleManager> ().ifPuzzleWin) {
			SceneManager.UnloadSceneAsync("PuzzleFive");
		}
	}
}
