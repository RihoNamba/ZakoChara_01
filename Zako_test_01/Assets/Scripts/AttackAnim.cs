using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnim : MonoBehaviour {

public Animator animator;
// Use this for initialization
　　void Start () {
　　　　animator = GetComponent<Animator>();
　　}

　　// Update is called once per frame
　　void Update () {

　　}

　　//アタックボタン
　　public void AttackButton(){
　　　　animator.SetBool ("attack", true);
Invoke("DelayMethod",1f);
           
　　}

void DelayMethod(){
	animator.SetBool ("attack", false);
}

}
