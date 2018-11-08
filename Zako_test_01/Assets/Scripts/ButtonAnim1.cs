using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAnim1 : MonoBehaviour {

public Animator animator;
public Button button;


    public Text scoreText; //Text用変数
    private int score = 0; //スコア計算用変数
	
	 
public GameObject gameobject;
public ScoreScript script;
 
	// Use this for initialization
	void Start () {
	}
	
	public void ButtonAnim1Set(){
		　　animator = GetComponent<Animator>();
		
		         script  = gameobject.GetComponent<ScoreScript>();
		
		
		　　AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);//ステートを取得
                 if ((stateInfo.IsName ("AttackButton01"))||(stateInfo.IsName ("AttackButtonOFF01"))) {
		//if(on == false){
			
			animator.SetBool ("on", true);
			
			
		}
	//else if (stateInfo.IsName ("AttackButtonON")) {
		
　　　　//animator.SetBool ("on", false);
           
		//}
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
	
	
	
	
		}
		
		public void OnClick(){
			animator.SetBool ("on", false);
			
			
		}
}
