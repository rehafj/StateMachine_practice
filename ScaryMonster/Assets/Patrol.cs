using UnityEngine;
using System.Collections;

public class Patrol : MonoBehaviour {

	public GameObject[] points;
	public int counter = 0;

	public float minDist;
	public float speed;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float distance = Vector3.Distance( gameObject.transform.position, points[counter].transform.position);
	
	}
}
