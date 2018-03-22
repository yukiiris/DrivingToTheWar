using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetBooks : MonoBehaviour {
	public GameObject textParent;
	public GameObject bookParent;
	private Text text;
	private GameObject book;
	private Vector3 bookPos = new Vector3(0,0,0);
	private Vector3 textPos = new Vector3 (800, 400, 0);
	public int[] randomNum;
	public GameObject rm;
	public GameObject[] books;
	public Text[] texts;
	private float textY = 400f;

	private int size;
	private int length;

	private bool init = true;

	private int i = 0;

	void Start () {
		size = books.Length;
		length = randomNum.Length;
		//随机数生成
//		bool ifagain = false;
//		randomNum [0] = Random.Range (0, size);
//
//		while (i < length) {
//			randomNum [i] = Random.Range (0, size);
//			while (m < i) {
//				if (randomNum [m] == randomNum [i]) {
//					ifagain = true;
//				}
//				++m;
//			}
//			if (ifagain == false) {
//				++i;
//			} else {
//				ifagain = false;
//			}
//			m = 0;
//		}
		randomNum = rm.GetComponent<RandomNum>().randomNum;

		//放置内容
	
			
	}
	
	// Update is called once per frame
	void Update () {
		if (init) {	
			while(i<length){
				//文字
				text = Instantiate (texts [randomNum [i]]);
				text.transform.parent = textParent.transform;
				text.transform.localScale = new Vector3(1, 1, 1);
				textPos.y = textY;
				textY = textY - 50f;
				text.transform.localPosition = textPos;

				//book
				book = Instantiate (books [randomNum [i]]);
				bookPos = book.transform.localPosition;
				book.transform.parent = bookParent.transform;
				book.transform.localPosition = bookPos;
				book.GetComponent<SearchPoint> ().text = text;
				book.GetComponent<SearchPoint> ().manager = bookParent.transform.GetChild (0).gameObject;
				i++;
			}
			init = false;
		}
	}
}
