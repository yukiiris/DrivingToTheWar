using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notebook : MonoBehaviour {

	public bool isClick = false;
	public GameObject notebook;
	private Vector3 pos;

	void Start () {
		pos = transform.position;
	}

	void Update () {

		if (isClick == false && gameObject.transform.position.x > 6.5f)
		{
			execute();
			isClick = true;
		}
	}

	private void OnMouseDown()
	{
		isClick = true;
	}

	private void OnMouseUp()
	{
		isClick = false;
		if (!(gameObject.transform.position.x > 6.5f )) {
			transform.position = pos;
		}
	}

	public void execute()
	{
		gameObject.SetActive(false);
		notebook.SetActive(true);
	}
}
