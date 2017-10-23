using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntPos : MonoBehaviour {
	private float myX;
	private float myY;
	public bool ifXOdd = false;
	public bool ifYOdd = false;

	void OnMouseUp(){
		if (gameObject.transform.localPosition.y > 0) {
			if (gameObject.transform.localPosition.x > 0) {
				if (ifXOdd == false) {
					myX = (int)(gameObject.transform.localPosition.x + 0.5);
				}
				if (ifXOdd == true) {
					myX = (int)gameObject.transform.localPosition.x + 0.5f;
				}
			}
			if (gameObject.transform.localPosition.x < 0) {
				if (ifXOdd == false) {
					myX = (int)(gameObject.transform.localPosition.x - 0.5);
				}
				if (ifXOdd == true) {
					myX = (int)gameObject.transform.localPosition.x - 0.5f;
				}
			}
			if (ifYOdd == false) {
				myY = (int)(gameObject.transform.localPosition.y + 0.5);
			}
			if (ifYOdd == true) {
				myY = (int)gameObject.transform.localPosition.y +0.5f;
			}
			gameObject.transform.position = new Vector3 (myX, myY, gameObject.transform.position.z);
		}
	}

}
