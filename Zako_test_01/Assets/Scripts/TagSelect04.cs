using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TagSelect04 : MonoBehaviour {
	
	//List<GameObject> colList = new List<GameObject>();
//int damageIndex    = 0;


 // Inspector
   // [SerializeField] private FadeScript anotherScript;
//public  FadeScript anotherScript;

public Button button;
public Image image;

public Text text;
public Text secondText;

	// Use this for initialization
	void Start () {
		
		
	  string anotherObjectName = "OKButton";
        GameObject anotherObject = GameObject.Find("OKButton");
     
	 string nextObjectName = "Image04_02";
        GameObject nextObject = GameObject.Find("Image04_02");
     
	 
	string ObjectName = "YazirushiText04";
        GameObject Object = GameObject.Find("YazirushiText04");
		
		string secondObjectName = "BigYazirushiTex";
        GameObject secondObject = GameObject.Find("BigYazirushiText");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//オブジェクトが触れている間
void OnTriggerStay2D(Collider2D other) {
	
	
	// if (other.gameObject.CompareTag("Material") && !colList.Contains(other.gameObject))
    //colList.Add(other.gameObject);
	
if (other.gameObject.tag == "Material04")
   
 //if ((((other.gameObject.tag == "Material01")&&(other.gameObject.tag == "Material02")&&(other.gameObject.tag == "Material03")&&(other.gameObject.tag == "Material04"))))
            {


button.gameObject.SetActive (true);

image.gameObject.SetActive (true);

text.gameObject.SetActive (false);

secondText.gameObject.SetActive (true);
}
}
	
	
}