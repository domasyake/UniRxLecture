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
				.Buffer(2, 1)//イベントを纏める
				.Where(list => list[0] > double_click_interval)
				.Where(list => list[1]<= double_click_interval)//インターバル以内にクリックされているかチェック
				.Subscribe(n => Debug.Log("Double click!"));
			
			var test_buffet_subject=new Subject<int>();
			test_buffet_subject.Buffer(2,1)
				.Subscribe(n => Debug.Log(n[0]+","+n[1]));
			
			var temp_num = new int[]{0,1, 2, 3, 4, 5, 6, 7, 8, 9};
			foreach (var item in temp_num){
				test_buffet_subject.OnNext(item);
			}
		}
	
		private void Update () {
			if (Input.GetMouseButtonDown(0)){
				clickCheckStream.OnNext(Unit.Default);
			}
		}
	}
}
