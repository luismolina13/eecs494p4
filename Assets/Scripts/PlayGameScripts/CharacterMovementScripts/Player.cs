using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public float moveSpeed = 20.0f;
	public float deadZone = 0.3f;

	bool attack = false;
	public float attack_cd = 0.0f;

	// Use this for initialization
	void Start() 
	{
	
	}

	void Movement()
	{
		if (!attack) 
		{
			if (Input.GetAxis ("L_YAxis_1") != 0 || Input.GetAxis ("L_XAxis_1") != 0)  
			{
				animation.Play ("Walk");
			}
			else
			{
				animation.Play ();
			}
		}

		float z_pos = transform.position.z + Input.GetAxis ("L_YAxis_1") * moveSpeed * Time.deltaTime;
		float x_pos = transform.position.x + Input.GetAxis ("L_XAxis_1") * moveSpeed * Time.deltaTime;
		transform.position = new Vector3 (x_pos, 5, z_pos);
		
		if((Mathf.Abs (Input.GetAxis("R_XAxis_1")) > deadZone || Mathf.Abs(Input.GetAxis ("R_YAxis_1")) > deadZone)
		   && !attack)
		{
			Vector3 temp_vec = new Vector3 (Input.GetAxis("R_XAxis_1") * 1000, 5, Input.GetAxis ("R_YAxis_1") * -1000);
			transform.LookAt (temp_vec);
		}	
	}

	// Update is called once per frame
	void Update() 
	{	
		Movement ();

		if (attack) 
		{
			attack_cd -= Time.deltaTime;
			if(attack_cd <= 0)
			{
				attack = false;
				animation.Play ();
			}
		}

		if (Input.GetAxis ("TriggersR_1") == 1.0f && !attack) 
		{
			animation.Play ("Attack");
			attack = true;
			attack_cd = 1.533f;
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
