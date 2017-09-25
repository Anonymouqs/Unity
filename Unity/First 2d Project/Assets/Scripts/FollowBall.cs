using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 otherX = GameObject.Find ("BallSprite").transform.position;
		gameObject.transform.position = otherX + new Vector3(0,2,0);
	}
}
