using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelcontroller : MonoBehaviour {
	private int currentLevel;
	public level StartLevel;

	// Use this for initialization
	void Start () {
		//StartLevel.BeginLevel ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Next(level theLevel){
		Debug.Log ("loading level");
		//StartLevel.SetActive (false);
		StartLevel.EndLevel();

		if (theLevel != null) {
			theLevel.BeginLevel ();		
		}

		StartLevel = theLevel;
	}
}
