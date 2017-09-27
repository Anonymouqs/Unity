using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour {
	public Sprite flagClosed;
	public Sprite flagOpen;
	private SpriteRenderer theSpriteRenderer;
	// Use this for initialization
	void Start () {
		theSpriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onTrigger2DEnter(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			theSpriteRenderer.sprite = flagOpen;
		}
	}
}
