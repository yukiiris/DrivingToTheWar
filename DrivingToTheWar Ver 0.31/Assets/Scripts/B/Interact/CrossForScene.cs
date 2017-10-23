using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CrossForScene : MonoBehaviour {

	public string toUnload;
	public GameObject block;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		block = GameObject.Find ("bigbox");
		block.SetActive (false);
		SceneManager.UnloadSceneAsync(toUnload);
	}
}
