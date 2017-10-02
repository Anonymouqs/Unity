using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonHover : MonoBehaviour {
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnMouseOver()
	{
		anim.SetFloat("mouseOver",(true));
	}
	void OnMouseExit()
	{
		anim.SetFloat("mouseOver",false);
	}
}
