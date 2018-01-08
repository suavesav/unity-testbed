using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public GameObject player;
	private Vector3 gap;

	void Start(){
		gap = transform.position - player.transform.position;
	}

	void LateUpdate () {
		transform.position = player.transform.position + gap;
	}
}
