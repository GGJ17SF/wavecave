using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {


	public float speed;
	public GvrHead head;
	private Rigidbody rb;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>(); 
		rb.position = transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (head == null) {
			//unity sucks
			head = Camera.main.GetComponent<StereoController> ().Head;
		}
		rb.position += speed * head.Gaze.direction;
	}
}
