using UnityEngine;
using System.Collections;

public class SelectorController : MonoBehaviour {

	float play_game = 1218.628f;//7.80f;
	float instructions = 1213.764f;//2.75f;
	float sandbox = 1208.076f;//-3.20f;
	float quit = 1201.841f;//-8.78f;

	bool key_up_released = false;
	bool key_down_released = false;

	// 0 playgame, 1 instructions, 2 sandbox, 3 quit
	int state = 0; 
	const int num_options = 4;

	// Use this for initialization
	void Start () {
		renderer.material.color = Color.yellow;
	}

	// Update is called once per frame
	void Update () {
		bool key_up_pressed = Input.GetAxis ("L_YAxis_1") > .3;
		if (Input.GetAxis ("L_YAxis_1") < .3) {
			key_up_released = true;
		}

		bool key_down_pressed = Input.GetAxis ("L_YAxis_1") < -.3;
		if (Input.GetAxis ("L_YAxis_1") > -.3) {
			key_down_released = true;
		}

		bool key_enter = Input.GetButtonDown ("A_1");

		if (key_up_pressed && key_up_released) {
			state--;
			key_up_released = false;
		}
		if (key_down_pressed && key_down_released) {
			state++;
			key_down_released = false;
		}
		if (state >= num_options) 
			state = 0;
		if (state < 0)
			state = num_options - 1;
		switch (state) {
			case 0:
				transform.position = new Vector3 (transform.position.x, transform.position.y, play_game);
				if(key_enter)
					Application.LoadLevel(1);
				break;
			case 1:
				transform.position = new Vector3 (transform.position.x, transform.position.y, instructions);
				if(key_enter)
					Application.LoadLevel(1);				
				break;
			case 2:
				transform.position = new Vector3 (transform.position.x, transform.position.y, sandbox);
				if(key_enter)
					Application.LoadLevel(1);
				break;
			case 3:
				transform.position = new Vector3 (transform.position.x, transform.position.y, quit);
				if(key_enter)					
					Application.Quit();
				break;
		}	
	}

}
