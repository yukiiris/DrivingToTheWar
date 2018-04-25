using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfMedshelfWin : MonoBehaviour {
	private PuzzleManager pm;
	private Interact it;
	private C_OneWords co;
	public GameObject med;
	public GameObject medpre;

	// Use this for initialization
	void Start () {
		pm = gameObject.GetComponent<PuzzleManager> ();
		it = transform.parent.parent.gameObject.GetComponent<Interact> ();
		co = transform.parent.parent.gameObject.GetComponent<C_OneWords> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (pm.ifPuzzleWin) {
			EventButton.buttons [6] = true;
			co.enabled = true;
			it.enabled = false;
			transform.parent.gameObject.SetActive (false);
			med.SetActive (true);
			medpre.SetActive (false);
		}
	}
}
