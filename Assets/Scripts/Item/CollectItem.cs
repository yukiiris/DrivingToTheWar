using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour {

	void OnTriggerStay(Collider item){
		if (item.gameObject.GetComponent<ItemCommon> () != null)
			item.gameObject.transform.localPosition = new Vector3 (item.gameObject.transform.localPosition.x,item.gameObject.transform.localPosition.y,-0.5f);
			item.gameObject.transform.SetParent (gameObject.transform);
		//ArchiveManager.save();
	}
		
}
