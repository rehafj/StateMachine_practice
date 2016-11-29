using UnityEngine;
using System.Collections;


/// based on a tutorial for fps camera movments 
/// original credit for this script goes to Holistic3d

public class CameraTurn : MonoBehaviour {


	Vector2 mouseLook;
	Vector2 smoothV;

	public float sensitivity = 5;
	public float smoothing = 2;

	GameObject chare;

	// Use this for initialization
	void Start () {


		chare = this.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {

		 if (Input.GetMouseButton(0)){

	var md = new Vector2 ( Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

	md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
	smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f/smoothing);
	smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f/smoothing);
	mouseLook += smoothV;

	transform.localRotation = Quaternion.AngleAxis( -mouseLook.y, Vector3.right);
	chare.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, chare.transform.up);
	
	}}
}
