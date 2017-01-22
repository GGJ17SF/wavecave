using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMaterialController : MonoBehaviour {

	public Material inactiveMaterial;
	public Material gazedAtMaterial;
	public Renderer rend;
	public playerController player;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
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
		float n = player.targetDistance;
		float xsize = Mathf.PingPong(Time.time, 1.0F);
		rend.material.SetFloat("_Tilingx", xsize * 0.3F);
		float ysize = Mathf.PingPong(Time.time, 1.2F) + 0.5f;
		rend.material.SetFloat("_Tilingy", ysize * n);
		float zsize = Mathf.PingPong(Time.time, 1.1F);
		rend.material.SetFloat("_Tilingz", zsize * 0.3F);
	}
}
