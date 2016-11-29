using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public enum States { patrol, patrolBlue, chase, IDLE } 
		public States mystate;

	ColorChange GameState;
	PathFinding monsterPath ; 
	public bool Onetime;
		//patrol - goes between 4 locations 
		//if chased the player and cannot see it goes back to point a 
		// 

		//idle stops completly 


		//look around 

		//patrol in red blue state - check place in red / black states - increase search size 


	// Use this for initialization




	void Awake () {
		GameState = FindObjectOfType<ColorChange>();
		monsterPath = FindObjectOfType<PathFinding>();
		mystate = States.IDLE;

	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log(mystate.ToString());

		if( mystate != States.chase){
			if( GameState.mystate == ColorChange.States.Yellow){
				mystate = States.IDLE;
			
		}
			if( GameState.mystate == ColorChange.States.Blue){
			if( mystate != States.chase){
					mystate = States.patrol;
					
					}	

		
		}

		} else{ //monster is chasing player 
			monsterPath.newTarger = monsterPath.player;

			
		}
		}

	
	
	//only find player if all boxes are deactivated 
	//			monsterPath.chooseAmongActive();

	//if monster is in chase and color is red find player - this only happens when the player is close by scedule path to player 

}

