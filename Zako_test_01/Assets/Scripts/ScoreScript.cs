using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour{
	
    public Text scoreText; //Text用変数
    public int score = 0; //スコア計算用変数
	public int hit1 = 0; //
	public int hit2 = 0; //
	public int hit3 = 0; //
	   
	
	 
public Button button1,button2,button3 ;

public GameObject gameobject1,gameobject2,gameobject3;

public Slider slider1,slider2,slider3,slider4;
     int _hp1 = 0;
     int _hp2 = 0;
     int _hp3 = 0;
     int _hp4 = 0;

 private ButtonAnim buttonAnim;
 private ButtonAnim1 buttonAnim1;
 private ButtonAnim3 buttonAnim3;
 
    void Start()
    {
        score   = 0;
        SetScore();   //初期スコアを代入して表示
		
	
		　　
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
			
	//_hp1 += 100f;
			// HPゲージに値を設定
   // slider1.value = _hp1;
			
	//_hp2 += 100f;
			// HPゲージに値を設定
    //slider2.value = _hp2;
	
	//_hp3 += 100f;
			// HPゲージに値を設定
    //slider3.value = _hp3;
        }

        SetScore();
		
		
    }

    void SetScore()
    {
        scoreText.text = string.Format( "Score:{0}", score );
    }
	
	void Update(){
		
	if (hit1 >= 0 ){
		_hp1 = score;
			// HPゲージに値を設定
    slider1.value = _hp1;
		}
		
		if (hit2 >= 0 ){
		_hp2 = score;
			// HPゲージに値を設定
    slider2.value = _hp2;
		}
	
	if (hit3 >= 0 ){
		_hp3 = score;
			// HPゲージに値を設定
    slider3.value = _hp3;
		}
		
			_hp4 = score;
			// HPゲージに値を設定
    slider4.value = _hp4;
		
		
	    // スコアが〜〜より大きければ
    if(hit2< score) {
      //button2.gameObject.SetActive (true);
 buttonAnim  = gameobject2.GetComponent<ButtonAnim>();
 buttonAnim.ButtonAnimSet();
           

	}
	
       if(hit1< score) {
      //button2.gameObject.SetActive (true);
 buttonAnim1  = gameobject1.GetComponent<ButtonAnim1>();
 buttonAnim1.ButtonAnim1Set();

	}
	
	    if(hit3< score) {
     // button3.gameObject.SetActive (true);
 buttonAnim3  = gameobject3.GetComponent<ButtonAnim3>();
 buttonAnim3.ButtonAnim3Set();

   
	
    }
	}
	//public void OnClick(){
	
	public void AttackButtonPushed(){

		// スコアを0に戻す
		if(hit2< score) {	
 			score -= 1000;
 			SetScore();
			
			_hp2 = 0;
	          
	
// HPゲージに値を設定
    slider2.value = _hp2;
		}
	}
		public void AttackButton1Pushed(){

		// スコアを0に戻す
		if(hit1< score) {	
 			score -= 1600;
 			SetScore();
			
					_hp1 = 0;
	
	
// HPゲージに値を設定
    slider1.value = _hp1;
		}
	}
		
	
		public void AttackButton3Pushed(){

		// スコアを0に戻す
		if(hit3< score) {	
 			score -= 2200;
 			SetScore();
			
					_hp3 = 0;
	
	
// HPゲージに値を設定
    slider3.value = _hp3;
		}
	 }
		
	}
