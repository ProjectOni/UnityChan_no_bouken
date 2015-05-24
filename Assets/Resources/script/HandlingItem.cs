using UnityEngine;
using System.Collections;

public class HandlingItem : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("h")) {
			// プレハブを取得
			GameObject prefab = (GameObject)Resources.Load ("prefabs/hacksaw");
			GameObject item = Instantiate (prefab, this.transform.position, prefab.transform.rotation)as GameObject;
			item.transform.parent = this.transform;
		}
	}
}
