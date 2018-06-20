using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour {
 
  
	// Use this for initialization
	void Start () {
		
	}
	
	
    // Update is called once per frame
    void Update () {
        if(Input.GetMouseButtonDown(0)){
		
            // マウスがクリックされたら以下を実行
            ClickScript clickScript = GetComponent<ClickScript >();
            clickScript .PopUp();
        }
    
	}
}
