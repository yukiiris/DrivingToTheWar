using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balance : MonoBehaviour {

	public Transform transform;
	public int delta = 30;
	public float speed = 0.3f;
	public float waitTime = 0.01f;
	// Use this for initialization
	void Start () {
		StartCoroutine(f());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnMouseDown()
	{
		
	}

	IEnumerator f()
	{
		float i = 0;
		while (i < delta)
		{
			transform.Rotate(new Vector3(0, 0, speed));
			i += speed;
			yield return new WaitForSeconds(waitTime);
		}
	}
}
