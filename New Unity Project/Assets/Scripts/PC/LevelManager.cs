using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
	public float respawnTime;
	public PlayerController player;
	// Use this for initialization
	void Start () 
	{
		player = FindObjectOfType <PlayerController> ();

	}
	
	// Update is called once per frame
	void Update () 
	{
	

	}
	public void respawn()
	{
		player.gameObject.SetActive (false);
		player.transform.position = player.respawn;
		player.gameObject.SetActive (true);
	
	
	}
}

