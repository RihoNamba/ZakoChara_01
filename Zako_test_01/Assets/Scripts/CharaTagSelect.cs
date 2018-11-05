using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharaTagSelect : MonoBehaviour {

 // Inspector
   // [SerializeField] private FadeScript anotherScript;
//public  FadeScript anotherScript;
public Button button;


	// Use this for initialization
	void Start () {
		
		 string anotherObjectName = "ResetButton";
        GameObject anotherObject = GameObject.Find("ResetButton");
       
	
       
	}
	// Update is called once per frame
	void Update () {
		
	}
	//オブジェクトが触れている間
void OnTriggerStay2D(Collider2D other) {
	 if ((((other.gameObject.tag == "ZakoDra")||(other.gameObject.tag == "Usagi")||(other.gameObject.tag == "Hiyoko")||(other.gameObject.tag == "Kamibukuro"))))
	 
            {


button.gameObject.SetActive (true);
 
       
}
	
}


	
	//void OnTriggerExit2D(Collider2D other) {
		// if ((((other.gameObject.tag == "ZakoDra")&&(other.gameObject.tag == "Usagi")&&(other.gameObject.tag == "Hiyoko")&&(other.gameObject.tag == "Kamibukuro"))))
	 
          //  {
				//button.gameObject.SetActive (false);
//}
//}
}
	

