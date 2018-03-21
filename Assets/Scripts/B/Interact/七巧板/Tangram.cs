using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tangram : MonoBehaviour {
	public TangramManager tangramManager;
	public float[] x = new float[4];
	public float[] y = new float[4];
	public int[] angels = new int[4];
	public int angel = 1;

	public GameObject arrow;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Mathf.Abs(transform.position.x - x[tangramManager.n]) < 1 && Mathf.Abs(transform.position.y - y[tangramManager.n]) < 1)
		{
			transform.position = new Vector3(x[tangramManager.n], y[tangramManager.n], transform.position.z);
			print(transform.position.x);
			tangramManager.a++;
			GetComponent<Drag>().enabled = false;
		}
	}

	private void OnMouseDown()
	{
		arrow.SetActive(true);
	}
}
