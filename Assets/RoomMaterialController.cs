using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMaterialController : MonoBehaviour {

	public Material inactiveMaterial;
	public Material gazedAtMaterial;
	public Renderer rend;
	public playerController player;
	private float n; //level one dist variable
	private float o;
	private float p;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		n = 1;
		o = 0;
		p = 0;
	}


	public void SetGazedAt(bool gazedAt) {
		if (inactiveMaterial != null && gazedAtMaterial != null) {
			GetComponent<Renderer>().material = gazedAt ? gazedAtMaterial : inactiveMaterial;
			return;
		}
		GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.red;

	}


		// Update is called once per frame
	void Update () {

		if (player != null) {
			if (player.targetDistance < 4.0f) {
				n = (4.0f - player.targetDistance) + 1;
				rend.material.SetFloat ("_Distance", n);
			}
		}

		float xsize = Mathf.Sin(Time.time);
		rend.material.SetFloat("_Tilingx", xsize * 0.3F);
		float ysize = Mathf.Sin(Time.time * 0.7f) + 0.5f;
		rend.material.SetFloat("_Tilingy", ysize * n);
		float zsize = Mathf.Sin(Time.time * 0.3f);
		rend.material.SetFloat("_Tilingz", zsize * 0.7F);

	}
}
