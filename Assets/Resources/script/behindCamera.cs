using UnityEngine;
using System.Collections;

public class behindCamera : MonoBehaviour {
	
	public GameObject player;

	void Start(){
		this.player = GameObject.FindGameObjectWithTag ("Player");
		}

	// Update is called once per frame
	void Update () {
		
		//プレイヤーどの位置に置くか
		transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
		transform.rotation = new Quaternion (0, player.transform.rotation.y, 0, player.transform.rotation.w);
//		transform.rotation = player.transform.rotation;

//		transform.LookAt (player.transform);
		Debug.Log (player.transform.rotation);
	}
}