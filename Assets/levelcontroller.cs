using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelcontroller : MonoBehaviour {
	private int currentLevel;
	public GameObject StartLevel;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Next(GameObject level){
		Debug.Log ("loading level");
		StartLevel.SetActive (false);
		level.SetActive (true);
		StartLevel = level;
	}
}
