using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton: MonoBehaviour {
	
public GameObject gameobject;
public Button button;


	// Use this for initialization
	void Start () {
		
	 string anotherObjectName = "ResetButton01";
        GameObject anotherObject = GameObject.Find("ResetButton01");
		
		
		
	}
       
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnClick() {
		
		button.gameObject.SetActive (false);
		
		
		
		Vector3 tmp =　GameObject.FindGameObjectWithTag("ZakoDra").transform.position;
		//GameObject.Find("ZakoDra").
		GameObject.FindGameObjectWithTag("ZakoDra").
	transform.position = new Vector3(tmp.x, tmp.y - 420, tmp.z);
		
		
		
		//script = button.GetComponent<ResetPositionScript>();
		 //script.ResetPosition();
		 
	}
	void RayTest()
    {
        //Rayの作成　　　　　　　↓Rayを飛ばす原点　　　↓Rayを飛ばす方向
        Ray ray = new Ray (transform.position, new Vector3 (0, 10, 0));

        //Rayが当たったオブジェクトの情報を入れる箱
        RaycastHit hit;

        //Rayの飛ばせる距離
        int distance = 10;

        //Rayの可視化    ↓Rayの原点　　　　↓Rayの方向　　　　　　　　　↓Rayの色
        Debug.DrawLine (ray.origin, ray.direction * distance, Color.red);

        //もしRayにオブジェクトが衝突したら
        //                  ↓Ray  ↓Rayが当たったオブジェクト ↓距離
        if (Physics.Raycast(ray,out hit,distance))
        {
              //Rayが当たったオブジェクトのtagがPlayerだったら
                if (hit.collider.tag == "ZakoDra")
                Debug.Log ("RayがZakoDraに当たった");
				//transform.position = new Vector3(transform.position.x, transform.position.y - 420, transform.position.z);
			
		
        }
    }

}
		
		








