using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AattackScript02 : MonoBehaviour {
	
public GameObject attackButton;


	void Start () {
		
		
	}
	// Update is called once per frame
	void Update () {
		
	}
	//public void OnClick(){
		
	
		//attackButton.gameObject.SetActive (false);
		//}
		
		
	 public void OnClick() {
    Debug.Log("AttackButton02 click!");
    // 非表示にする
    gameObject.SetActive(false);
    // Buttonを表示する
   // MyCanvas.SetActive("Button", true);
   
   

}
}
