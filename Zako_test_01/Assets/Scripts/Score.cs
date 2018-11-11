using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour{
	
    public Text scoreText; //Text用変数
    private int score = 0; //スコア計算用変数
	public int hit = 0; //

	 
public Button button ;
public Slider slider ;
 int _hp = 0;

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
		
		if (hit >= 0 ){
		_hp = score;
			// HPゲージに値を設定
    slider.value = _hp;
		}
		
	    // スコアが〜〜より大きければ
    if(hit< score) {
      button.gameObject.SetActive (true);

 // スコアを0に戻す
  //score = 0;
	}
	

	}
	
	public void AttackButtonChPushed(){

		// スコアを0に戻す
		if(hit< score) {	
		
		 button.gameObject.SetActive (false);
		 
 			score = 0;
 			SetScore();
		}
	}
}