using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHerbNote : MonoBehaviour {

	void OnMouseDown(){
		EventButton.buttons [17] = true;
		EventButton.ifNoteChange = true;
		Destroy (this);
	}

}
