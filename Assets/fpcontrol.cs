using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpcontrol : MonoBehaviour {
	public float speed;
	public GvrHead head;
	// Use this for initialization
	void Start () {
		
		//head = Camera.main.GetComponent<StereoController>().Head;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (head == null) {
			//unity sucks
			head = Camera.main.GetComponent<StereoController> ().Head;
		}
		transform.position += speed * head.Gaze.direction;
	}
}
