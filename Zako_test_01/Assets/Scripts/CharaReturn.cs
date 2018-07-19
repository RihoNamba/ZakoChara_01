using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaReturn : MonoBehaviour {

	SpriteRenderer spriteRenderer; 
public Sprite sprite1;
  
  void Start () {
	spriteRenderer = GetComponent<SpriteRenderer>();
	spriteRenderer.sprite = sprite1;
}
	
   
	
	// Update is called once per frame
	void Update () {
		
	}
}
