﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickObject : MonoBehaviour {
	public GameObject panelObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonUp(0)){
			panelObject.SetActive(true);
		}
			

}
}

