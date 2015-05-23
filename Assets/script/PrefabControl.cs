using UnityEngine;
using System.Collections;

public class PrefabControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<NetworkView>().isMine) {
						if (Input.GetKey ("up")) {
								transform.position += transform.forward * 0.1f;
						}
				}
	}
}
