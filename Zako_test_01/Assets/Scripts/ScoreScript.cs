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

public GameObject gameobject;

//public Canvas canvas;

 private ButtonAnim buttonAnim;
 
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
            score += 50;
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
    if(hit1< score) {
     // button1.gameObject.SetActive (true);
 buttonAnim  = gameobject.GetComponent<ButtonAnim>();
 
           
 // スコアを0に戻す
  //score = 0;
	}
	
       if(hit2< score) {
      button2.gameObject.SetActive (true);

 // スコアを0に戻す
 // score = 0;
	}
	
	    if(hit3< score) {
      button3.gameObject.SetActive (true);

 // スコアを0に戻す
 // score = 0;
   
	
    }
	}
	public void OnClick(){
	//public void ScoreReset(){
		// スコアを0に戻す
	if(hit1< score) {	
 score = 0;
	}
	}
}