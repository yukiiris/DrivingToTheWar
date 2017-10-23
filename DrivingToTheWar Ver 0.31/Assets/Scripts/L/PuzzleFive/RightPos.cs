using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPos : MonoBehaviour {
	public float rightXPos;
	public float rightYPos;
	public bool ifOnRightPlace = false;
	public GameObject manager; 

	void OnMouseUp(){
		if (gameObject.transform.localPosition.x == rightXPos&&gameObject.transform.localPosition.y == rightYPos&&ifOnRightPlace==false) {
			manager.GetComponent<PuzzleManager> ().rightNum++;
			ifOnRightPlace = true;
		}
		if ((gameObject.transform.localPosition.x != rightXPos||gameObject.transform.localPosition.y != rightYPos)&&ifOnRightPlace==true) {
			manager.GetComponent<PuzzleManager> ().rightNum--;
			ifOnRightPlace = false;
		}
	}
}
