using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeButton : MonoBehaviour {

	public GameObject toLoad;
	public GameObject toUnload;
	public Dialog dialog;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{

		if (!Black.isActive)
		{
			CameraManager.isChanging = true;
			
			CameraManager.change(toLoad, toUnload);
		}
	}
}
