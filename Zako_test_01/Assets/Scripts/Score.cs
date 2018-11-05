using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour{
	
    public Text scoreText; //Text用変数
    private int score = 0; //スコア計算用変数
	 public int hit = 0; //

	 
public Button button ;

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
	    // スコアが〜〜より大きければ
    if(hit< score) {
      button.gameObject.SetActive (true);

 // スコアを0に戻す
  score = 0;
	}
	

	}
}