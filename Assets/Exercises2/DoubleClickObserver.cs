using System;
using System.Linq;
using UniRx;
using UnityEngine;

namespace Exercises2{
	public class DoubleClickObserver : MonoBehaviour {

		private readonly Subject<Unit> clickCheckStream=new Subject<Unit>();//自分の判定に使うだけなのでprivate
		
		private void Start (){
			var double_click_interval = 0.25d;//ダブルクリックのインターバル
		
			clickCheckStream
				.TimeInterval()//直前のイベント発行からの時間差分ストリームに変換
				.Select(t => t.Interval.TotalSeconds)//差分の秒数ストリームに変換
				//イベントを纏める
				//インターバル以内にクリックされているかチェック
				.Subscribe(n => Debug.Log("Double click!"));
		}
	
		private void Update () {
			if (Input.GetMouseButtonDown(0)){
				//イベント発行
			}
		}
	}
}
