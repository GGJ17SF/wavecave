using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLevelController : MonoBehaviour {
	public GameObject NextLevel;
	public levelcontroller LevelBuilder;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void GoNextLevel(){
		LevelBuilder.Next (NextLevel);
	}

}
