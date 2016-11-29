using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {

	public float duration = 1.0F;
    public Color color0 = Color.red;
    public Color color1 = Color.blue;
    public Light lt;

    GameObject SecretDorr;

    public  GameObject [] BlueDoors;

	public float timeLeft = 30f;


	PLayerFPS plr;
	CameraMan cameraa;
	public enum States {Red, Blue, Yellow, Black, Green}
	public States mystate;
	States lastState;
	MusicManager music; 
    public int changeCounter;
    PathFinding monsterpath;

    void Awake(){
    	plr = FindObjectOfType<PLayerFPS>(); 
		cameraa = FindObjectOfType<CameraMan>();
		music = FindObjectOfType<MusicManager>();
		BlueDoors = GameObject.FindGameObjectsWithTag("BD");
		monsterpath = FindObjectOfType<PathFinding>();

    }
    void Start() {
    	
        lt = GetComponent<Light>();
		lt.color = Color.yellow;
		mystate =  States.Yellow;
		lastState = States.Yellow;
		timeLeft = 10;
		SecretDorr = GameObject.FindGameObjectWithTag("SD");

    }
    void Update() {
    	timeLeft -= Time.deltaTime;

		if(mystate != States.Red){
			if(timeLeft<0 ){
       	
			setStrangeColor();

		//add code to recalcuate path for a star and set it based on monster and directions - for path construction 

        }
    }}


    public void setStrangeColor (){
		

    	
    	int rnd = Random.Range(-1,10);
		if(rnd <= 2 && lastState != States.Blue ){
    		//blue head control 
			//play with player speed and limit movment 
			//player can jump on obsticules - 
			//snake thing can go on sea obstacle - same speed 
			//add a varible instead :) and have it based on satte - blue - red - white - yellow 
			mystate =  States.Blue;
			lastState = mystate;
			plr.speed = 12;
			lt.color = Color.blue;
			SecretDorr.SetActive(true);
			foreach( GameObject door in BlueDoors){
				door.SetActive(false);
			}
			timeLeft = 12;
			cameraa.CanClick = false;


    	}
		else if (rnd >2 && rnd <=4  && lastState != States.Green){
			//Idle  control 
			//play with player speed and boost movemnt 
			plr.speed = 8;
			mystate =  States.Green;
			lastState = mystate;
			lt.color = Color.green;
			cameraa.CanClick = true;
			monsterpath.reachedEndRed = false;
		//	music.PlayMusic();
			timeLeft = 7;
			foreach( GameObject door in BlueDoors){
				door.SetActive(true);
			}}


    
		else if (rnd == 5  && lastState != States.Black){
			//Idle  control 
			//play with player speed and boost movemnt 
			SecretDorr.SetActive(true);
			cameraa.CanClick = false;
			monsterpath.reachedEndRed = false;
			plr.speed = 0;
			mystate =  States.Black;
			lastState = mystate;
			lt.color = Color.white;
			timeLeft = 6;
			foreach( GameObject door in BlueDoors){
				door.SetActive(true);
			}}
//		else if ( rnd == 3 && lastState!= States.Red){
//				RedSstate();
//		}

    	
		else  {
			//play with player speed and boost movemnt 
			//yellow head control head control  - snake is slow 
			if( lastState != States.Yellow){
				cameraa.CanClick = false;
				monsterpath.reachedEndRed = false;
				SecretDorr.SetActive(true);
				plr.speed = 8;
				mystate =  States.Yellow;
				lastState = mystate;
				timeLeft = 10;
				lt.color = Color.yellow;
				foreach( GameObject door in BlueDoors){
				door.SetActive(true);
			}
			}
    	}
		music.PlayMusic();
    


    }

    public void AfterChaseColor(){
		lastState = States.Blue;


    }
	/*	else if (rnd == 2 && lastState != States.Red){
			//red head control head control 
			//stop player actions 
			//snake thing is fast 
			SecretDorr.SetActive(false);
			foreach( GameObject door in BlueDoors){
				door.SetActive(true);
			}
			mystate =  States.Red;
			lastState = mystate;
			plr.speed = 5;
			lt.color = Color.red;
			music.PlayMusic();
			timeLeft = 10;
			cameraa.CanClick = false;


    	}*/


    public void RedSstate(){
			mystate =  States.Red;
			lastState = mystate;
			SecretDorr.SetActive(false);
			foreach( GameObject door in BlueDoors){
				door.SetActive(true);
			}
			plr.speed = 15;
			lt.color = Color.red;
			music.PlayMusic();
			//timeLeft = 10;
			cameraa.CanClick = false;

    	
    }
}

/*
 float t = Mathf.PingPong(Time.time, duration) / duration;
        lt.color = Color.Lerp(color0, color1, t);


           if(lt.color == color0){
       		 lt.color = Color.blue;}
		if(lt.color == color1){
       		 lt.color = Color.red;}*/


