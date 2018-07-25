using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
 
public class PauseScript : MonoBehaviour {
 
 public GameObject GameObject;

	//　ポーズした時に表示するUI
	[SerializeField]
	private GameObject pauseUI;
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale == 0){
			return;
		}
	
	}
	public void PanelButtonPushed(){
		
		
			//　ポーズUIのアクティブ、非アクティブを切り替え
			pauseUI.SetActive (!pauseUI.activeSelf);
			
		
			//　ポーズUIが表示されてる時は停止
			if(pauseUI.activeSelf) {
				Time.timeScale = 0f;
				GameObject.Find("PausableObjects").GetComponent<Pausable>().pausing= true ;
				//pausable.bool pausing.enabled = true ;
				
			//　ポーズUIが表示されてなければ通常通り進行
			} else {
				Time.timeScale = 1f;
				GameObject.Find("PausableObjects").GetComponent<Pausable>().pausing= false ;
				//pausable.bool pausing.enabled = false ;
	            
	}
				if(Application.loadedLevelName != "Start"){
					Time.timeScale = 1f;
					
				}
			}
		
			
			
	
		}
		

 