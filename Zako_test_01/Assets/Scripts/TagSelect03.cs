using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TagSelect03 : MonoBehaviour {
	
	
public Image image;

public Text text;
public Text secondText;

	// Use this for initialization
	void Start () {
		
		
	  
	 string nextObjectName = "Image03_02";
        GameObject nextObject = GameObject.Find("Image03_02");
     
	 
	string ObjectName = "YazirushiText03";
        GameObject Object = GameObject.Find("YazirushiText03");
		
		string secondObjectName = "YazirushiTex04";
        GameObject secondObject = GameObject.Find("YazirushiText04");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//オブジェクトが触れている間
void OnTriggerStay2D(Collider2D other) {
	
	
	
if (other.gameObject.tag == "Material03")

            {




image.gameObject.SetActive (true);

text.gameObject.SetActive (false);

secondText.gameObject.SetActive (true);
}
}
	
	
}
