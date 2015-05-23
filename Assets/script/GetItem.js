#pragma strict

function OnTriggerEnter (collider : Collider) {
	
	if (collider.tag == "Player") {
		Destroy(this.gameObject);
		return;
	}
}

function OnTriggerExit (collider : Collider) {
}

function Start () {

}

function Update () {

}

