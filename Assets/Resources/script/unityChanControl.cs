using UnityEngine;
using System.Collections;

public class unityChanControl : MonoBehaviour {

	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
//		if (GetComponent<NetworkView>().isMine) {
						//  run & turn
						if (Input.GetKey ("up")) {
								animator.SetBool ("is_run", true);
								transform.position += transform.forward * 0.1f;
						} else {
								animator.SetBool ("is_run", false);
						}

						if (Input.GetKey ("right")) {
								transform.Rotate (0, 5, 0);
						}
						if (Input.GetKey ("left")) {
								transform.Rotate (0, -5, 0);
						}

						// jump
						if (Input.GetKey ("space")) {
								animator.SetBool ("is_damagedown", true);
						} else {
								animator.SetBool ("is_damagedown", false);
						}

						// jab
						if (Input.GetKey ("a")) {
								animator.SetBool ("is_jab", true);
						} else {
								animator.SetBool ("is_jab", false);
						}

						// hikick
						if (Input.GetKey ("s")) {
								animator.SetBool ("is_hikick", true);
						} else {
								animator.SetBool ("is_hikick", false);
						}
				}

//	}
}
