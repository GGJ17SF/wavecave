using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLevelController : MonoBehaviour {
	public levelcontroller levelBuilder;
	public int nextLevel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onCollisionEnter (Collision col) {
		if (levelBuilder != null) {
			levelBuilder.SetLevel (nextLevel);

		}
	}
}
