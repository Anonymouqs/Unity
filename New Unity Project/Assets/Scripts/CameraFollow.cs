using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	public GameObject player = GameObject.Find ("Player");
	private Vector3 target;
	private Vector3 cameraPos;
	public float cameraZ;  //This is the Z value for the Camera
	public float moveRate;//Overall Interpolation Speed to move to player
	public float followAhead;

	private Vector3 targetPosition;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		cameraPos = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,gameObject.transform.position.z);
		GameObject.Find ("Player");
		target = new Vector3 (player.transform.position.x, player.transform.position.y, cameraZ);


		//transform.position = targetPosition;
		//if(target.transform.localScale.x > 0 f))
		//{ target Position = new Vector3(targetPosition + followAhead, targetPosition.y, target position.z) }
		//else{{ target Position = new Vector3(targetPosition + -git followAhead, targetPosition.y, target position.z) }}
	}
}
