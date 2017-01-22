using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelcontroller : MonoBehaviour {
	private int currentLevel;
	// Use this for initialization
	void Start () {
		currentLevel = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetLevel(int level){
		Debug.Log ("loading level");
		currentLevel = level;

	}
}
