﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class IntroGUI : MonoBehaviour {
	private Button button; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Application.LoadLevel ("Intro");
	}
	void OnClick()
	{
	}
}
