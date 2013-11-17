using UnityEngine;
using System.Collections;

public class TextController : MonoBehaviour {

	void OnCollisionEnter(Collision collision) {
		//change the color of the text
		renderer.material.color = Color.yellow;
	}

	void OnCollisionExit(Collision collision) {
		//change the color of the text
		renderer.material.color = Color.white;			
	}
}
