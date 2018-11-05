using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Access : MonoBehaviour {

public GameObject gameobject;
ObjectOnScript script ;

	// Use this for initialization
	void Start () {
		
		 //Object objectOn= gameobject.GetComponent<ObjectOnScript>();
		 script = gameobject.GetComponent<ObjectOnScript>();
		 script.ObjectOn();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
