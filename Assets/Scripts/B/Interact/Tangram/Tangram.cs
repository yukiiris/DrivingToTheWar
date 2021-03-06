﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tangram : MonoBehaviour {
	public TangramManager tangramManager;
	public float[] x = new float[4];
	public float[] y = new float[4];
	public int[] angels = new int[4];
	public int angel = 1;
	public bool flag = true;

	public GameObject arrow;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (tangramManager.n > 3)
		{
			return;
		}
		if (Mathf.Abs(transform.position.x - 2.77f - x[tangramManager.n]) < 0.1 && Mathf.Abs(transform.position.y + 0.81f - y[tangramManager.n]) < 0.1 && flag)
		{
			transform.position = new Vector3(x[tangramManager.n] + 2.77f, y[tangramManager.n] - 0.81f, transform.position.z);
			tangramManager.a++;
			GetComponent<Drag>().enabled = false;
			flag = false;
		}
	}
}
