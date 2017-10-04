using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
	public float respawnTime; // in seconds
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
		player.transform.position = player.respawn;
		StartCoroutine ("RespawnCo");
	
	}

	public IEnumerator respawnCo()
	{
		player.gameObject.SetActive (false);
		yield return new WaitForSeconds (respawnTime);
		player.transform.position = player.respawn;
		player.gameObject.SetActive (true);

	}
}

