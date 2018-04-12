using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour {

	void OnTriggerStay(Collider item){
		if(item.gameObject.GetComponent<ItemCommon>()!=null)
			item.gameObject.transform.SetParent (gameObject.transform);
		//ArchiveManager.save();
	}
		
}
