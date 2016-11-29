using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {

	public float timeLeft = 20
	;
	void Update(){
		 timeLeft-=Time.deltaTime;

		if(timeLeft< 0){
			Debug.Log("activating object");
			gameObject.SetActive(true);
		}
	}
	

	void OnTriggerEnter(Collider other) {

		if (other.tag == "Player" ) {

			gameObject.SetActive(false);
			timeLeft = 5;

   		 
   	  }

  

     //start state chase  and path find
     	
 }
}
