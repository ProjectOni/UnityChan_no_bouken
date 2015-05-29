using UnityEngine;
using System.Collections;

public class HandlingItem : MonoBehaviour {

	private string weaponName;
	// Use this for initialization
	void Start () {
		weaponName = "";
	}
	
	// Update is called once per frame
	void Update () {

		if (unityChanState.IsEquipRight ()) {
			if(!unityChanState.GetWeaponNameRight().Equals(weaponName)){
				Destroy(GameObject.Find(weaponName));
				weaponName = unityChanState.GetWeaponNameRight();
				Debug.Log("weaponName = " + weaponName);
				GameObject prefab = (GameObject)Resources.Load ("prefabs/" + weaponName);
				Debug.Log("prefab = " + prefab);
				GameObject item = Instantiate (prefab, this.transform.position, prefab.transform.rotation)as GameObject;
				item.transform.parent = this.transform;

				Debug.Log("weaponName = " + weaponName);

			}
		}
	}
}
