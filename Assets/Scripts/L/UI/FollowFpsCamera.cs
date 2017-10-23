using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowFpsCamera : MonoBehaviour {

	public GameObject copy;
	public GameObject cam;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
//		transform.position = copy.transform.position;
//		transform.rotation = copy.transform.rotation;
		transform.LookAt(cam.transform);
	}
}
