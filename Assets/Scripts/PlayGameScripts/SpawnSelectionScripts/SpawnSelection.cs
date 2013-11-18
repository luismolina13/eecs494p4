using UnityEngine;
using System.Collections;

public class SpawnSelection : MonoBehaviour {

	public Transform warrior_prefab;
	public Transform mage_prefab;
	public Transform archer_prefab;

	public int player_number = 1;

	bool key_left_released = false;
	bool key_right_released = false;

	float warrior;
	float mage;
	float archer;

	float x;
	float y;
	float z;
	
	// 0 golem, 1 warrior, 2 archer
	int state = 0; 
	const int num_options = 3;

	void Start () {
		warrior = transform.parent.transform.position.x + 0.0f;
		mage = transform.parent.transform.position.x + 3.5f;
		archer = transform.parent.transform.position.x - 3.5f;

		x = transform.parent.transform.position.x;
		y = transform.parent.transform.position.y - 5.0f;
		z = transform.parent.transform.position.z + 2.3f;
	}

	void selectCharacter(string type) {

	}

	// Update is called once per frame
	void Update () {
		bool key_left = Input.GetKeyUp (KeyCode.LeftArrow);
		bool key_right = Input.GetKeyUp (KeyCode.RightArrow);
		bool key_enter = Input.GetKeyUp (KeyCode.Return) || Input.GetButtonDown ("A_" + player_number);

		bool key_left_pressed = Input.GetAxis ("L_XAxis_" + player_number) < -.3;
		bool key_right_pressed = Input.GetAxis ("L_XAxis_" + player_number) > .3;

		if (Input.GetAxis ("L_XAxis_" + player_number) > -.3)
				key_left_released = true;
		if (Input.GetAxis ("L_XAxis_" + player_number) < .3)
				key_right_released = true;

		if (key_left || (key_left_pressed && key_left_released)) {
			state++;
			key_left_released = false;
		}
		if (key_right || (key_right_pressed && key_right_released)) {
			state--;
			key_right_released = false;
		}
		if (state >= num_options) 
			state = 0;
		if (state < 0)
			state = num_options - 1;
		switch (state) {
		case 0:
			transform.position = new Vector3 (mage, y, z);
			if(key_enter) {
				Instantiate (mage_prefab, new Vector3(x,3.812794f,z), Quaternion.identity);
				//player.GetComponent
				Object.Destroy(transform.parent.gameObject);
			}
				//Application.LoadLevel(1);
			break;
		case 1:
			transform.position = new Vector3 (warrior, y , z);
			if(key_enter) {
				Instantiate (warrior_prefab, new Vector3(x,3.812794f,z), Quaternion.identity);
				Object.Destroy(transform.parent.gameObject);
			}
				//Application.LoadLevel(1);				
			break;
		case 2:
			transform.position = new Vector3 (archer, y, z);
			if(key_enter) {
				Instantiate (archer_prefab, new Vector3(x,3.812794f,z), Quaternion.identity);
				Object.Destroy(transform.parent.gameObject);
			}
				//Application.LoadLevel(1);
			break;
		}	
	}
}
