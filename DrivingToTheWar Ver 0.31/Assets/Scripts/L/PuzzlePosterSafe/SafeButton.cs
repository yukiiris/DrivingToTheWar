using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeButton : MonoBehaviour {

	public float z1 = 0;
	public float w1 = 0;
	public bool ifRight = false;
	public bool ifOnRightPlace = false;
	public GameObject manager;

	void OnMouseDrag(){
		if (((gameObject.transform.rotation.z <= (z1 + 0.1) && gameObject.transform.rotation.z >= (z1 - 0.1) && gameObject.transform.rotation.w <= (w1 + 0.1) && gameObject.transform.rotation.w >= (w1 - 0.1)) ||
		   (gameObject.transform.rotation.z <= (-z1 + 0.1) && gameObject.transform.rotation.z >= (-z1 - 0.1) && gameObject.transform.rotation.w <= (-w1 + 0.1) && gameObject.transform.rotation.w >= (-w1 - 0.1)) ||
		   (gameObject.transform.rotation.w <= (z1 + 0.1) && gameObject.transform.rotation.w >= (z1 - 0.1) && gameObject.transform.rotation.z <= (-w1 + 0.1) && gameObject.transform.rotation.z >= (-w1 - 0.1)) ||
		   (gameObject.transform.rotation.w <= (-z1 + 0.1) && gameObject.transform.rotation.w >= (-z1 - 0.1) && gameObject.transform.rotation.z <= (w1 + 0.1) && gameObject.transform.rotation.z >= (w1 - 0.1)))) {
			ifOnRightPlace = true;
		} else {
			ifOnRightPlace = false;
		}


		transform.Rotate (0, 0, 1);
		//print (gameObject.transform.rotation.z);
		//print (gameObject.transform.rotation.w);
		if(ifOnRightPlace==true && ifRight==false) {
			manager.GetComponent<PuzzleManager> ().rightNum++;
			ifRight = true;
		}
		if(ifOnRightPlace==false&&ifRight==true){
			manager.GetComponent<PuzzleManager> ().rightNum--;
			ifRight = false;
		}
	}
}
