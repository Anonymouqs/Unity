using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		Vector3 otherX = GameObject.Find ("BallSprite").transform.position;
		gameObject.transform.position = otherX + new Vector3(0,0,-222);

		gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,-222);
	}
}