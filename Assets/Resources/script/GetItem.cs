using UnityEngine;
using System.Collections;

public class GetItem : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider){
		if (collider.tag == "Player") {
			if(!unityChanState.IsEquipRight()){
				unityChanState.SetIsEquipRight(true);
			}
			unityChanState.SetWeaponNameRight(this.gameObject.name);
			Destroy(this.gameObject);
			return;
		}

	}

}
