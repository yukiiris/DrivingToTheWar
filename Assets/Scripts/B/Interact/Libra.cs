using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Libra : MonoBehaviour {

	public GameObject rod;
	public GameObject leftChain;
	public GameObject rightChain;
	public GameObject leftTray;
	public GameObject rightTray;
	private bool turnLeft;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		print(weight());
	}


	private void OnTriggerStay(Collider other)
	{
		if (Weight.isMouseUp)
		{
			other.GetComponent<Transform>().SetParent(gameObject.GetComponent<Transform>());
			other.gameObject.GetComponent<Weight>().isChild = true;
		}
	}

	private void rorate()
	{
		
	}

	private int weight()
	{
		int left = 0;
		int right = 0;
		for (int i = leftTray.GetComponent<Transform>().childCount; i > 0; i--)
		{
			left += leftTray.GetComponent<Transform>().GetChild(i - 1).gameObject.GetComponent<Weight>().weight;
		}

		for (int i = rightTray.GetComponent<Transform>().childCount; i > 0; i--)
		{
			right += rightTray.GetComponent<Transform>().GetChild(i).gameObject.GetComponent<Weight>().weight;
		}

		return left - right;
	}
}
