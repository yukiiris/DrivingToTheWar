using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchPoint : MonoBehaviour {
	public Text text;
	public bool ifSearch = false;
	private Color col;
	public Vector3 pos = new Vector3 (0, 0, 0);
	public GameObject manager;

	void Start () {
		col = text.color;
	}

	void Update(){
		if (ifSearch == true && col.r < 0.6f) {
			col.r = col.r + 2 * Time.deltaTime;
			col.g = col.g + 2 * Time.deltaTime;
			col.b = col.b + 2 * Time.deltaTime;
			text.color = col;
		}
		if (col.r > 0.6f) {
			gameObject.SetActive (false);
		}
	}

	void OnMouseDown(){
		if (ifSearch == false) {
			manager.GetComponent<PuzzleManager> ().rightNum++;
		}
		ifSearch = true;
	}

}
