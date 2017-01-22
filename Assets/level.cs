using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level : MonoBehaviour {

	public GvrAudioSource ambient1;
	public GvrAudioSource ambient2;
	public GvrAudioSource ambient3;
	public GvrAudioSource ambient4;


	public GvrAudioSource target;

	public float MaxVolume;



	// Use this for initialization
	void Start () {
		MaxVolume = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	public void BeginLevel(){
		StartCoroutine (fadeIn ());

	}

	public void EndLevel(){
		StartCoroutine (fadeOut ());
	}


	void setVol (float level){
		if (ambient1 != null) {
			ambient1.volume = level;
		}
		if (ambient2 != null) {
			ambient2.volume = level;
		}
		if (ambient3 != null) {
			ambient3.volume = level;
		}
		if (ambient4 != null) {
			ambient4.volume = level;
		}

		if (target != null) {
			target.volume = level;
		}
	}

	IEnumerator fadeIn()
	{
		setVol (0.0f);

		float t = 0.0f;
		while (t < MaxVolume) {
			t += Time.deltaTime;
			setVol (t);
			target.pitch = t;
			yield return new WaitForSeconds(0);
		}
	}
	IEnumerator fadeOut()
	{
		float t = MaxVolume;
		while (t > 0.0f) {
			t -= (Time.deltaTime / 2.0f);
			setVol (t);
			target.pitch = t;
			yield return new WaitForSeconds(0);
		}
		setVol(0.0f);
	}

}
