using System;
using UniRx;
using UnityEngine;

namespace Exercises2{
	public class DoubleClickObserver : MonoBehaviour {

		private readonly Subject<Unit> clickCheckStream=new Subject<Unit>();//自分の判定に使うだけなのでprivate
		
		private void Start (){
			//オペレータでほにゃららしてダブルクリック判定する
			clickCheckStream
				.Subscribe(n => Debug.Log("Double click!"));
		}
	
		private void Update () {
			if (Input.GetMouseButtonDown(0)){
				//イベント発行
			}
		}
	}
}
