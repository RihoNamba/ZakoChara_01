using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton02: MonoBehaviour {
	
public GameObject gameobject;
public Button button;


	// Use this for initialization
	void Start () {
		
	 string anotherObjectName = "ResetButton02";
        GameObject anotherObject = GameObject.Find("ResetButton02");
		
		
		
	}
       
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnClick() {
		
		button.gameObject.SetActive (false);
		
		
		
		Vector3 tmp =　GameObject.FindGameObjectWithTag("Usagi").transform.position;
		//Vector3 tmp = GameObject.Find("ZakoDra").transform.position;
		//GameObject.Find("ZakoDra").
		GameObject.FindGameObjectWithTag("Usagi").
		transform.position = new Vector3(tmp.x, tmp.y - 440, tmp.z);
		
	}
}
		
		