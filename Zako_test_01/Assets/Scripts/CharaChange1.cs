using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using UnityEngine.EventSystems;

public class CharaChange1 : MonoBehaviour {


   
SpriteRenderer spriteRenderer; 
public Sprite sprite1;
  
  void Start () {
	spriteRenderer = GetComponent<SpriteRenderer>();
	spriteRenderer.sprite = sprite1;
}
	
   }

		
