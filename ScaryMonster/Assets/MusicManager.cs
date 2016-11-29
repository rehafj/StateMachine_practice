using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip [] clips;
	AudioSource m ;
	public ColorChange state ;
	// Use this for initialization
	void Start () {

	m = gameObject.GetComponent<AudioSource>();
	state = FindObjectOfType<ColorChange>();
	m.playOnAwake = false;
	}
	
	// Update is called once per frame
	public void PlayMusic () {

		m.Stop();
		if(state.mystate == ColorChange.States.Black){
			m.loop = false;
            m.clip = clips[0];//dark clip - short time

            m.Play();

		}
		if(state.mystate == ColorChange.States.Red){
			
			m.clip = clips[1];
			m.loop = true;
            m.Play();
          
		}if(state.mystate == ColorChange.States.Blue){
	
			m.clip = clips[2];
			m.Play();
			Debug.Log("stopping music");
		}

		else {


		}
	
	}
}
