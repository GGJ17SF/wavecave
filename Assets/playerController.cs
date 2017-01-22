using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {


	public float speed;
	public GvrHead head;
	public bool moving;
	public levelcontroller levelBuilder;

	private Rigidbody rb;
	private int levelcounter;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>(); 
		rb.position = transform.position;
		//moving = false;
		levelcounter = 1;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (head == null) {
			//unity sucks
			head = Camera.main.GetComponent<StereoController> ().Head;
		}
		if (moving) {
			rb.position += speed * head.Gaze.direction;
		}

	}
	void OnCollisionEnter(Collision col){
		moving = false;
	}

	void OnTriggerEnter(Collider other){
		levelcounter += 1;
		levelBuilder.SetLevel (levelcounter);
		Debug.Log ("next level!");
	}

}
