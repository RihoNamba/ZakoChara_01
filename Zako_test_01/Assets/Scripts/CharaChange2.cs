using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaChange2 : MonoBehaviour {

	SpriteRenderer spriteRenderer; 
public Sprite sprite1,sprite2;
  
  void Start () {
	spriteRenderer = GetComponent<SpriteRenderer>();
	spriteRenderer.sprite = sprite1;

 
  }
	// Update is called once per frame
	void Update () {
	
	
	
spriteRenderer = GetComponent<SpriteRenderer>();
	spriteRenderer.sprite = sprite2;

		
	}
	
}
