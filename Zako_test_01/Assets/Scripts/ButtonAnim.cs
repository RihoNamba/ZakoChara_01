using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAnim : MonoBehaviour {

public Animator animator;
public Button button;


    public Text scoreText; //Text用変数
    private int score = 0; //スコア計算用変数
	
	 
public GameObject gameobject;
public ScoreScript script;
 
	// Use this for initialization
	void Start () {
		　　animator = GetComponent<Animator>();
		
		 script  = gameobject.GetComponent<ScoreScript>();
		
		
		　　AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);//ステートを取得
if ((stateInfo.IsName ("AttackButton02"))||(stateInfo.IsName ("AttackButtonOFF"))) {
		//if(on == false){
			
			animator.SetBool ("on", true);
			
			
		}
	//else if (stateInfo.IsName ("AttackButtonON")) {
		
　　　　//animator.SetBool ("on", false);
           
		//}
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
	
	
	
	　　//AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);//ステートを取得
//if (stateInfo.IsName ("AttackButton02")) {
		//if(on == false){
			
			//animator.SetBool ("on", true);
			
			
		//}
	//else {
		
　　　//　animator.SetBool ("on", false);
           
		//}
		}
		
		public void OnClick(){
			animator.SetBool ("on", false);
			
			// script  = gameobject.GetComponent<ScoreScript>();
			//script.ScoreReset();
		}
}
