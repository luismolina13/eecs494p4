#pragma strict

var moveSpeed: float = 1.0;
var turnSpeed: float = 1.0;

function Update () {

	if(Input.GetButton("W")) {
		transform.position += transform.forward * moveSpeed * Time.deltaTime;
		animation.Play("Walk");
	}
	else if(Input.GetButton("S")) {
		transform.position += -transform.forward * moveSpeed * Time.deltaTime;
		animation.Play("Walk");
	}
	else {
		animation.Play("idle");
	}
	
	if(Input.GetButton("A")) {
		transform.eulerAngles.y += -turnSpeed * Time.deltaTime;
	}
	if(Input.GetButton("D")) {
		transform.eulerAngles.y += turnSpeed * Time.deltaTime;
	}

}