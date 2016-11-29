using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class EnemySight : MonoBehaviour {

	EnemyAI enemyState;
	PathFinding monspath;
	ColorChange time;

void Awake(){

		enemyState = FindObjectOfType<EnemyAI>();
		monspath = FindObjectOfType<PathFinding>();
		time = FindObjectOfType<ColorChange>();
}


void OnTriggerEnter(Collider other) {
		if (other.tag == "Player" ) {

			enemyState.mystate = EnemyAI.States.chase;
			time.RedSstate();
   			Debug.Log("HIT PLAYER enemy is in chase ");
   		 	

   		 
   	  }

   	  if( other.tag =="REDPoint"){
   	  	int z = Random.Range(-70,105);
		int x = Random.Range(-64,60);
   	  	other.transform.position = new Vector3( x, other.transform.position.y, z);
   	  	Invoke("WaitAndActiveate",2);
			//monspath.reachedEndRed = true;

   	  }

     //start state chase  and path find
     	
 }


 void OnTriggerExit(Collider other) {
		if (other.tag == "Player") {
			Debug.Log("enemy is out of chase mode ");
			time.AfterChaseColor();
			time.setStrangeColor();
			enemyState.mystate = EnemyAI.States.IDLE;

		}

    
     //satart state lost
 }


	public 	void WaitAndActiveate(){

		monspath.reachedEndRed = false;
	}

}
