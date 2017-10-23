using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_MoveToNotebook : MonoBehaviour {
	public float speed = 0.1f;
	private float noteX = 8f;
	private float noteY = -4f;
	private float x;
	private float y;
	private Color col = Color.white;

	// Use this for initialization
	void Start () {
		StartCoroutine (MoveToNotebook ());	
		x = noteX - transform.position.x;
		y = noteY - transform.position.y;
	}
	
	IEnumerator MoveToNotebook(){
		for (int i = 0; i < 1 / speed; i++) {
			transform.Translate (x * speed, y * speed, 0);
			col.a = 1 - i *speed;
			GetComponent<SpriteRenderer> ().color = col;
			yield return null;
		}
		Destroy(gameObject);
		yield return null;

	}
}
