using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TagSelect : MonoBehaviour {

 // Inspector
   // [SerializeField] private FadeScript anotherScript;
//public  FadeScript anotherScript;
public Button button;

public Text text;
public Text secondText;

	// Use this for initialization
	void Start () {
		
		
	  string anotherObjectName = "OKButton";
        GameObject anotherObject = GameObject.Find("OKButton");
        //anotherScript = anotherObject.GetComponent<FadeScript>();
	string ObjectName = "YazirushiText";
        GameObject Object = GameObject.Find("YazirushiText");
		
		string secondObjectName = "BigYazirushiText";
        GameObject secondObject = GameObject.Find("BigYazirushiText");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//オブジェクトが触れている間
void OnTriggerStay2D(Collider2D other) {
	 if (other.gameObject.tag == "Material04")
            {

 //GetComponent<FadeScript>().enabled = true;
button.gameObject.SetActive (true);

text.gameObject.SetActive (false);

secondText.gameObject.SetActive (true);
}
}
	
}
