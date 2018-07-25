using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelHide : MonoBehaviour {
	public GameObject panelObject;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void PanelButtonPushed(){
		panelObject.SetActive(false);
	}
}