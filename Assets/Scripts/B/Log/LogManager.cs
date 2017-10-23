using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LogManager : MonoBehaviour {

	public Text text;
	private bool isShow = false;
	private string context;
	private float time;
	public bool isEmpty = true;
	// Use this for initialization
	void Start () {
		text = GameObject.FindGameObjectWithTag("text").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if (isShow)
		{
			StartCoroutine(show());
			isShow = false;
		}
	}

	public  void show(string context, float time)
	{
		this.context = context;
		isShow = true;
		this.time = time;
	}

	private IEnumerator show()
	{
		text.text = context;
		yield return new WaitForSeconds(time);
		text.text = "";
	}
}
