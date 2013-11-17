using UnityEngine;
using System.Collections;

public class characterRotate : MonoBehaviour {

	public GameObject frog;
	
	
	
	private Rect FpsRect ;
	private string frpString;
	
	private GameObject instanceObj;
	public GameObject[] gameObjArray=new GameObject[9];
	public AnimationClip[] AniList  = new AnimationClip[9];
	
	float minimum = 2.0f;
	float maximum = 50.0f;
	float touchNum = 0f;
	string touchDirection ="forward"; 
	private GameObject K_npcMEN;
	
	// Use this for initialization
	void Start () {
		
		//frog.animation["dragon_03_ani01"].blendMode=AnimationBlendMode.Blend;
		//frog.animation["dragon_03_ani02"].blendMode=AnimationBlendMode.Blend;
		//Debug.Log(frog.GetComponent("dragon_03_ani01"));
		
		//Instantiate(gameObjArray[0], gameObjArray[0].transform.position, gameObjArray[0].transform.rotation);
	}
	
 void OnGUI() {
	  if (GUI.Button(new Rect(20, 20, 70, 40),"Idle")){
		 frog.animation.wrapMode= WrapMode.Loop;
		  	frog.animation.CrossFade("Idle");
	  }
	    if (GUI.Button(new Rect(90, 20, 70, 40),"Negative")){
		  frog.animation.wrapMode= WrapMode.Loop;
		  	frog.animation.CrossFade("Negative");
	  }
	     if (GUI.Button(new Rect(160, 20, 70, 40),"Com")){
		  frog.animation.wrapMode= WrapMode.Loop;
		  	frog.animation.CrossFade("Com");
	  } 
		if (GUI.Button(new Rect(230, 20, 70, 40),"Bye")){
		  frog.animation.wrapMode= WrapMode.Loop;
		  	frog.animation.CrossFade("Bye");
	  }  
		if (GUI.Button(new Rect(300, 20, 70, 40),"Consent")){
		  frog.animation.wrapMode= WrapMode.Loop;
		  	frog.animation.CrossFade("Consent");
	  } 
		if (GUI.Button(new Rect(370, 20, 70, 40),"SP_Idle")){
		  frog.animation.wrapMode= WrapMode.Once;
		  	frog.animation.CrossFade("SP_Idle");
	  } 
		if (GUI.Button(new Rect(440, 20, 70, 40),"Walk")){
		  frog.animation.wrapMode= WrapMode.Loop;
		  	frog.animation.CrossFade("Walk");
	  } 
		if (GUI.Button(new Rect(510, 20, 70, 40),"Run")){
		  frog.animation.wrapMode= WrapMode.Loop;
		  	frog.animation.CrossFade("Run");
			
		}		
			if (GUI.Button(new Rect(20, 65, 70, 40),"Jump")){
		  frog.animation.wrapMode= WrapMode.Once;
		  	frog.animation.CrossFade("Jump");
	  } 
		if (GUI.Button(new Rect(90, 65, 70, 40),"Attack_stance")){
		  frog.animation.wrapMode= WrapMode.Loop;
		  	frog.animation.CrossFade("Attack_stance");
	  } 
		if (GUI.Button(new Rect(160, 65, 70, 40),"Attack")){
		  frog.animation.wrapMode= WrapMode.Once;
		  	frog.animation.CrossFade("Attack");
	  } 
		if (GUI.Button(new Rect(230, 65, 70, 40),"Attack1")){
		  frog.animation.wrapMode= WrapMode.Once;
		  	frog.animation.CrossFade("Attack1");
	  }
				if (GUI.Button(new Rect(300, 65, 70, 40),"Combo")){
		  frog.animation.wrapMode= WrapMode.Once;
		  	frog.animation.CrossFade("Combo");
			
		}		
			if (GUI.Button(new Rect(370, 65, 70, 40),"Skill")){
		  frog.animation.wrapMode= WrapMode.Once;
		  	frog.animation.CrossFade("Skill");
	  } 
		if (GUI.Button(new Rect(440, 65, 70, 40),"Push")){
		  frog.animation.wrapMode= WrapMode.Once;
		  	frog.animation.CrossFade("Push");
	  } 
		if (GUI.Button(new Rect(510, 65, 70, 40),"Buff")){
		  frog.animation.wrapMode= WrapMode.Once;
		  	frog.animation.CrossFade("Buff");
	  } 
		if (GUI.Button(new Rect(20,110, 70, 40),"Stun")){
		  frog.animation.wrapMode= WrapMode.Loop;
		  	frog.animation.CrossFade("Stun");
	  }
				if (GUI.Button(new Rect(90, 110, 70, 40),"Damage")){
		  frog.animation.wrapMode= WrapMode.Once;
		  	frog.animation.CrossFade("Damage");
	  }
				if (GUI.Button(new Rect(160, 110, 70, 40),"Dead")){
		  frog.animation.wrapMode= WrapMode.Once;
		  	frog.animation.CrossFade("Dead");
	  }
 }
	
	// Update is called once per frame
	void Update () {
		
		//if(Input.GetMouseButtonDown(0)){
		
			//touchNum++;
			//touchDirection="forward";
		 // transform.position = new Vector3(0, 0,Mathf.Lerp(minimum, maximum, Time.time));
			//Debug.Log("touchNum=="+touchNum);
		//}
		/*
		if(touchDirection=="forward"){
			if(Input.touchCount>){
				touchDirection="back";
			}
		}
	*/
		 
		//transform.position = Vector3(Mathf.Lerp(minimum, maximum, Time.time), 0, 0);
	if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
		//frog.transform.Rotate(Vector3.up * Time.deltaTime*30);
	}
	
}
