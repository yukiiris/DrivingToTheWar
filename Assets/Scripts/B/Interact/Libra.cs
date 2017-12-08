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
	private int delta = 0;
	private int delta_pr = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		delta = weight();
		if (delta != 0 && delta != delta_pr)
		{
			StartCoroutine(judge());
			delta_pr = delta;
		}
	}

	private IEnumerator judge()
	{

		float i = delta > 0 ? 25 : -25;
		float z = rod.transform.rotation.z;
		while (Mathf.Abs(i - z) > 1)
		{
			rod.transform.Rotate(new Vector3(0, 0, ((i - z) / Mathf.Abs(i - z)) * 0.1f));
			yield return new WaitForSeconds(0.05f);
		}
		
	}

	private void OnTriggerStay(Collider other)
	{
		print(11);
		if (Weight.isMouseUp)
		{
			other.GetComponent<Transform>().SetParent(leftTray.transform);
			other.gameObject.GetComponent<Weight>().isChild = true;
		}
	}

	private IEnumerator rorate(int n, int m)
	{
		for (int i = 0; i < n; i++)
		{
			rod.transform.Rotate(new Vector3(0, 0, m * 0.1f));
			yield return new WaitForSeconds(0.1f);
		}
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
