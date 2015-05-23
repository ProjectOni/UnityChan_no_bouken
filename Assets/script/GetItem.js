#pragma strict

function OnTriggerEnter (collider : Collider) {
	
	if (collider.tag == "Player") {
		Destroy(this.gameObject);
		return;
	}
	Debug.Log("capsule");
}

function OnCollisionEnter(collision: Collision) {
	Destroy(gameObject);
}

function OnTriggerExit (collider : Collider) {
}

function Start () {

}

function Update () {

}

