using UnityEngine;
using System.Collections;

public class SpawnSelection : MonoBehaviour {

	public Transform character;

	float warrior = 50.0f;
	float golem = 53.5f;
	float archer = 46.50f;
	
	// 0 golem, 1 warrior, 2 archer
	int state = 0; 
	const int num_options = 3;

	void selectCharacter(string type) {

	}

	// Update is called once per frame
	void Update () {
		bool key_left = Input.GetKeyUp (KeyCode.LeftArrow);
		bool key_right = Input.GetKeyUp (KeyCode.RightArrow);
		bool key_enter = Input.GetKeyUp (KeyCode.Return);
		if (key_left) 
			state++;
		if (key_right)
			state--;
		if (state >= num_options) 
			state = 0;
		if (state < 0)
			state = num_options - 1;
		switch (state) {
		case 0:
			transform.position = new Vector3 (golem, transform.position.y, transform.position.z);
			if(key_enter) {
				Instantiate (character);
				Object.Destroy(this.gameObject);
			}
				//Application.LoadLevel(1);
			break;
		case 1:
			transform.position = new Vector3 (warrior, transform.position.y, transform.position.z);
			if(key_enter) {
				Instantiate (character);
				Object.Destroy(this.gameObject);
			}
				//Application.LoadLevel(1);				
			break;
		case 2:
			transform.position = new Vector3 (archer, transform.position.y, transform.position.z);
			if(key_enter) {
				Instantiate (character);
				Object.Destroy(this.gameObject);
			}
				//Application.LoadLevel(1);
			break;
		}	
	}
}
