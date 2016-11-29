using UnityEngine;
using System.Collections;

public class CameraMan : MonoBehaviour {


	public GameObject[] cameras = new GameObject[2];
	public bool MapCameraIsActive;
	public bool CanClick = false;
	// Use this for initialization
	void Start () {

		MapCameraIsActive = false;
	}
	
	// Update is called once per frame
	void Update () {

	if( CanClick){

	if(Input.GetKeyDown(KeyCode.M)){

			MapCameraIsActive = !MapCameraIsActive;
		
	}

	if( MapCameraIsActive == false){
		cameras[1].SetActive(false);
		cameras[0].SetActive(true);
	
	}
	else{
		cameras[1].SetActive(true);
		cameras[0].SetActive(false);

	}



	
	}
		if (CanClick == false){
		cameras[1].SetActive(false);
		cameras[0].SetActive(true);


		}
}}
