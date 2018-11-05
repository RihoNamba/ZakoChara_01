using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyCanvas : MonoBehaviour {


   static Canvas _canvas;
  void Start () {
    // Canvasコンポーネントを保持
    _canvas = GetComponent<Canvas>();
  }

  /// 表示・非表示を設定する
  public static void SetActive(string AttackButton02, bool b) {
    foreach(Transform child in _canvas.transform) {
      // 子の要素をたどる
      if(child.name == AttackButton02) {
        // 指定した名前と一致
        // 表示フラグを設定
        child.gameObject.SetActive(b);
        // おしまい
        return;
      }
    }
  }
	// Use this for initialization
	//void Start () {
		
	//}
	
	// Update is called once per frame
	void Update () {
		
	}
}
