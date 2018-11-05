using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton03: MonoBehaviour {
	
public GameObject gameobject;
public Button button;


	// Use this for initialization
	void Start () {
		
	 string anotherObjectName = "ResetButton03";
        GameObject anotherObject = GameObject.Find("ResetButton03");
		
		
		
	}
       
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnClick() {
		
		button.gameObject.SetActive (false);
		
		
		
		Vector3 tmp =　GameObject.FindGameObjectWithTag("Hiyoko").transform.position;
		//Vector3 tmp = GameObject.Find("ZakoDra").transform.position;
		//GameObject.Find("ZakoDra").
		GameObject.FindGameObjectWithTag("Hiyoko").
		transform.position = new Vector3(tmp.x, tmp.y - 420, tmp.z);
		
	}
}
	