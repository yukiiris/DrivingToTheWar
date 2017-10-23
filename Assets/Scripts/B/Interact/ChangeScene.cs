using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public string scene;
	public GameObject block;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		SceneManager.LoadSceneAsync(scene, LoadSceneMode.Additive);
		block.SetActive (true);
	}
}
