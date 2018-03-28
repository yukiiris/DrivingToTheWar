using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerbsNote : MonoBehaviour {
	public GameObject rh;
	private int[] num;
	private int[] index = { 0, 1, 4, 6 };
	public GameObject[] icons;
	private bool iffirst = true;
	private int herb = 0;

	void Update(){
		if (iffirst&&rh.GetComponent<RightHerb>().ifready) {
			num = rh.GetComponent<RightHerb> ().randomnum;
			for (int i = 0; i < 4; i++) {
				herb = num [index [i]];
				switch (herb) {
				case 0:
					icons [i].GetComponent<SpriteRenderer> ().color = new Color (0.2f, 0.8f, 0.5f);
					break;
				case 1:
					icons [i].GetComponent<SpriteRenderer> ().color = new Color (0.1f, 0.1f, 0.1f);
					break;
				case 2:
					icons [i].GetComponent<SpriteRenderer> ().color = new Color (0.2f, 0.3f, 0.6f);
					break;
				case 3:
					icons [i].GetComponent<SpriteRenderer> ().color = new Color (0.35f, 0.75f, 0.1f);
					break;
				case 4:
					icons [i].GetComponent<SpriteRenderer> ().color = new Color (0.7f, 0.3f, 0f);
					break;
				case 5:
					icons [i].GetComponent<SpriteRenderer> ().color = new Color (0.55f, 0f, 0.65f);
					break;
				case 6:
					icons [i].GetComponent<SpriteRenderer> ().color = new Color (0.55f, 0f, 0f);
					break;
				case 7:
					icons [i].GetComponent<SpriteRenderer> ().color = new Color (0.95f, 0.95f, 0.95f);
					break;
				case 8:
					icons [i].GetComponent<SpriteRenderer> ().color = new Color (0.85f, 0.85f, 0.15f);
					break;
				default:
					print ("error");
					break;
				}
			}
			
			iffirst = false;
		}
	}

}
