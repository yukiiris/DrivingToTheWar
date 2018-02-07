using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tangram : MonoBehaviour {
	public TangramManager tangramManager;
	public float x;
	public float y;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Mathf.Abs(transform.position.x - x) < 1 && Mathf.Abs(transform.position.y - y) < 1)
		{
			transform.position = new Vector3(x, y, transform.position.z);
			print(transform.position.x);
			tangramManager.a++;
			GetComponent<Drag>().enabled = false;
		}
	}
}
