using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour {
	public float z = 0;
	void OnTriggerStay(Collider item){
		if (item.gameObject.GetComponent<ItemCommon> () != null)
			item.gameObject.transform.localPosition = new Vector3 (item.gameObject.transform.localPosition.x,item.gameObject.transform.localPosition.y,z);
			item.gameObject.transform.SetParent (gameObject.transform);
		//ArchiveManager.save();
	}
		
}
