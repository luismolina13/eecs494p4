using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public float moveSpeed = 8.0f;
	public float deadZone = 0.3f;

	// Use this for initialization
	void Start() 
	{
	
	}
	
	// Update is called once per frame
	void Update() 
	{
		float z_pos = transform.position.z + Input.GetAxis ("L_YAxis_1") * moveSpeed * Time.deltaTime;
		float x_pos = transform.position.x + Input.GetAxis ("L_XAxis_1") * moveSpeed * Time.deltaTime;
		transform.position = new Vector3 (x_pos, 5, z_pos);
		
		if(Mathf.Abs (Input.GetAxis("R_XAxis_1")) > deadZone || Mathf.Abs(Input.GetAxis ("R_YAxis_1")) > deadZone)
		{
			Vector3 temp_vec = new Vector3 (Input.GetAxis("R_XAxis_1") * 1000, 5, Input.GetAxis ("R_YAxis_1") * -1000);
			transform.LookAt (temp_vec);
		}		
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Sword") 
		{
			//audio.Play ();
		}
	}
}
