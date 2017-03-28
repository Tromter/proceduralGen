using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {


	public builder builder;
	public Vector3 placeholder;
	public Vector3 startpos;

	void Start(){
		startpos = transform.position;
	}


	void Update () {
		placeholder = transform.position;

		placeholder.y = builder.cameraPlace.y + 105f;
		placeholder.x = builder.cameraPlace.x;
		placeholder.z = builder.cameraPlace.z;

		transform.position = placeholder;
	}
}
