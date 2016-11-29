using UnityEngine;
using System.Collections;

public class PLayerFPS : MonoBehaviour {

//testing 
	public float speed = 10f;
	public 	bool canJump;
	public bool isGrounded;

	public float jumpForce = 5;
	Rigidbody rb;


	public Transform groundChecker;
	public float rad;
	public LayerMask isThisGround;

	ColorChange state;
	// Use this for initialization
	void Start () {

	rb = GetComponent<Rigidbody>();
	state = FindObjectOfType<ColorChange>();
	}
	
	// Update is called once per frame
	void Update () {

		var hitColliders = Physics.OverlapSphere(groundChecker.position, rad, isThisGround);
		isGrounded = hitColliders.Length > 0;

		if( state.mystate == ColorChange.States.Yellow){
			canJump = true;
		} else {
			canJump = false;
		}

		//isGrounded = Physics.OverlapSphere( groundChecker.position, rad , isThisGround);
		float y = Input.GetAxis("Vertical")* speed;
		float x = Input.GetAxis("Horizontal") * speed;

		y *= Time.deltaTime;
		x *= Time.deltaTime;

		transform.Translate(x , 0 , y);

		if( canJump && isGrounded) {
			if(Input.GetButtonDown("Jump")){

			rb.velocity = new Vector3( rb.velocity.x, jumpForce , rb.velocity.z);

		}
	
	}

	}


	///add code if player hits objects it becomes deactivated - and blue state goes away if all are deactivate 
}
