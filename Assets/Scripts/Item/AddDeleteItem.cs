using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddDeleteItem : MonoBehaviour {
	public GameObject item;
	public bool deletetest = false;
	public bool addtest = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (deletetest) {
			this.DeleteItem (0);
			deletetest = false;
		}
		if (addtest) {
			this.AddItem (0);
			addtest = false;
		}
	}

	public GameObject findChildWithNum(int num){
		for (int i = 0; i < item.transform.childCount; i++) {
			if (item.transform.GetChild (i).gameObject.GetComponent<ItemInfo> ().itemNum == num) {
				return(item.transform.GetChild (i).gameObject);
			}
		}
		return null;
	}

	public void DeleteItem(int num){
		this.findChildWithNum (num).SetActive (false);
	}

	public void AddItem(int num){
		this.findChildWithNum (num).SetActive (true);
	}
}
