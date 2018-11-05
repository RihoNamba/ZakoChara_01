using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TagSelect02 : MonoBehaviour {
	
	
public Image image;

public Text text;
public Text secondText;

	// Use this for initialization
	void Start () {
		
		
	  
	 string nextObjectName = "Image02_02";
        GameObject nextObject = GameObject.Find("Image02_02");
     
	 
	string ObjectName = "YazirushiText02";
        GameObject Object = GameObject.Find("YazirushiText02");
		
		string secondObjectName = "YazirushiTex03";
        GameObject secondObject = GameObject.Find("YazirushiText03");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//オブジェクトが触れている間
void OnTriggerStay2D(Collider2D other) {
	
	
	
if (other.gameObject.tag == "Material02")

            {




image.gameObject.SetActive (true);

text.gameObject.SetActive (false);

secondText.gameObject.SetActive (true);
}
}
	
	
}
