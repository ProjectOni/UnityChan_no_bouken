using UnityEngine;
using System.Collections;

public class unityChanState : MonoBehaviour {

	private static bool isEquipRight;
	private static string weaponNameRight;

	// Use this for initialization
	void Start () {
		isEquipRight = false;
		weaponNameRight = "";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static bool IsEquipRight(){
		return isEquipRight;
	}

	public static void SetIsEquipRight(bool isEquip){
		isEquipRight = isEquip;
	}

	public static string GetWeaponNameRight(){
		return weaponNameRight;
	}

	public static void SetWeaponNameRight(string weaponName){
		weaponNameRight = weaponName;
	}

}
