using UnityEngine;
using System.Collections;

public class SelectorController : MonoBehaviour {

	float play_game = 7.80f;
	float instructions = 2.75f;
	float sandbox = -3.20f;
	float quit = -8.78f;

	// 0 playgame, 1 instructions, 2 sandbox, 3 quit
	int state = 0; 
	const int num_options = 4;

	// Use this for initialization
	void Start () {
		renderer.material.color = Color.yellow;
	}

	// Update is called once per frame
	void Update () {
		bool key_up = Input.GetKeyDown (KeyCode.UpArrow);
		bool key_down = Input.GetKeyUp (KeyCode.DownArrow);
		bool key_enter = Input.GetKeyUp (KeyCode.Return);
		if (key_up) 
			state--;
		if (key_down)
			state++;
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
