using System;
using UnityEngine;

namespace Chapter2.Event{
	public class FiveSecondsCounterNormal : MonoBehaviour{

		private int timeCounter;
		
		public delegate void FiveSecondsEventHandler(int current_seconds);//イベント用delegate定義

		public event FiveSecondsEventHandler OnCountUp;//イベントハンドラ定義
		
		private void Update(){
			timeCounter += 1;
			if (timeCounter% (5*60)==0){//60fpsだから300nで5n秒
				OnCountUp?.Invoke(timeCounter/60);//秒数を引数にイベントを起こす
			}
		}
	}
}

