using UnityEngine;
using System.Collections;

public class SimpleFollowCamera : MonoBehaviour {



	[SerializeField]
	private GameObject target;
	[SerializeField]
	private Vector3 distance = new Vector3(0, 2, -4);
	[SerializeField]
	private Vector3 lookPoint = new Vector3(0, 1.35f, 0);
	
	private GameObject unitychan;
	
	void Start () {
	}
	
	void Update () {
		Vector3 lookVector;

		if (NetworkManager.obj) {
			this.transform.position = NetworkManager.obj.transform.position + distance;
			lookVector = NetworkManager.obj.transform.position + lookPoint - this.transform.position;
		} else {
			this.transform.position = target.transform.position + distance;
			lookVector = target.transform.position + lookPoint - this.transform.position;
		}

		this.transform.rotation = Quaternion.LookRotation(lookVector);
	}
}

