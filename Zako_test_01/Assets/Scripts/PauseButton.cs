﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PauseButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void PanelButtonPushed(){
		PauseScript pauseScript = GetComponent<PauseScript >();
	//pauseScript.PanelButtonPushed();
	}
}
