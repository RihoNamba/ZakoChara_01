using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBar : MonoBehaviour {

 public Slider slider;
 float _hp = 1;
 
 public Button button1,button2,button3,button4 ;
 public GameObject panelObject;
  public AudioSource AudioSource;
 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		 if(_hp < 0) {
		 panelObject.SetActive(true);
		 
		 // HPゲージに値を設定
          slider.value = _hp;
		  
		  AudioSource.Stop();
		 
	 }
		
	}
	
	public void AttackButton1Pushed(){
	
	_hp -= 0.05f;
	
	
// HPゲージに値を設定
    slider.value = _hp;
	
	}
	
	public void AttackButton2Pushed(){
	
	_hp -= 0.02f;
	
	
// HPゲージに値を設定
    slider.value = _hp;
	
	}
	
	public void AttackButton3Pushed(){
	
	_hp -= 0.08f;
	
	
// HPゲージに値を設定
    slider.value = _hp;
	
	}
	
	public void AttackButton4Pushed(){
	
	_hp -= 0.5f;
	
	
// HPゲージに値を設定
    slider.value = _hp;
	
	}
	
	
	 
	 
}
