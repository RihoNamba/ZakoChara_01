using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour{
	
    public Text scoreText; //Text用変数
    private int score = 0; //スコア計算用変数
	 public int hit1 = 0; //
	  public int hit2 = 0; //
	   public int hit3 = 0; //
	 
public Button button1,button2,button3 ;

public GameObject gameobject1,gameobject2,gameobject3;

//public Canvas canvas;

 private ButtonAnim buttonAnim;
 private ButtonAnim1 buttonAnim1;
  private ButtonAnim3 buttonAnim3;
 
    void Start()
    {
        score   = 0;
        SetScore();   //初期スコアを代入して表示
		
		//Object target ;
		//foreach (Transform child in canvas.transform){
           // if(child.name == "AttackButton02"){
              //  target = child.gameObject.GetComponent<ButtonAnim>();
			//}
		//}
                
	//gameobject = GetComponent<ButtonAnim>();
		　　
    }

    
    void OnCollisionEnter2D(Collision2D collision)
    {
        string yourTag  = collision.gameObject.tag;

        if( yourTag == "Player" )
        {
            score += 10;
        }
        else
	  {
            score += 100;
        }

        SetScore();
    }

    void SetScore()
    {
        scoreText.text = string.Format( "Score:{0}", score );
    }
	
	void Update(){
	    // スコアが〜〜より大きければ
    if(hit2< score) {
      //button2.gameObject.SetActive (true);
 buttonAnim  = gameobject2.GetComponent<ButtonAnim>();
 buttonAnim.ButtonAnimSet();
           
 // スコアを0に戻す
  //score = 0;
	}
	
       if(hit1< score) {
      //button2.gameObject.SetActive (true);
 buttonAnim1  = gameobject1.GetComponent<ButtonAnim1>();
 buttonAnim1.ButtonAnim1Set();
 // スコアを0に戻す
 // score = 0;
	}
	
	    if(hit3< score) {
     // button3.gameObject.SetActive (true);
 buttonAnim3  = gameobject3.GetComponent<ButtonAnim3>();
 buttonAnim3.ButtonAnim3Set();
 // スコアを0に戻す
 // score = 0;
   
	
    }
	}
	//public void OnClick(){
	
	public void AttackButtonPushed(){

		// スコアを0に戻す
		if(hit2< score) {	
 			score = 0;
 			SetScore();
		}
	}
		public void AttackButton1Pushed(){

		// スコアを0に戻す
		if(hit1< score) {	
 			score = 0;
 			SetScore();
		}
	}
		public void AttackButton3Pushed(){

		// スコアを0に戻す
		if(hit3< score) {	
 			score = 0;
 			SetScore();
		}
	}
}