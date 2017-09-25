using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour 
{
	public AudioSource coinSound;
	
	void OnTriggerEnter2D(Collider2D other)
	{

			

		if (other.gameObject.tag == "Player") 
		{
			print ("PlayerCollision");
			Score.score = Score.score + 1;
			coinSound.Play();
			Destroy(gameObject);


		}
	}
}